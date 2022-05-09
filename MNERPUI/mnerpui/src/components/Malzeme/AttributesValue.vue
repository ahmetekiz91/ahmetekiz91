
<style>
  input[type="checkbox"] {
    transform: scale(2, 2);
  }
</style>
<template>
  <div class="content-wrapper">
    <div class="container-fluid">
      <div class="col-12">
        <div class="card mt-2">
          <div class="card-header">
            <div class="row">
              <div class="col-5">
                <button type="button" class="btn btn-info btn-sm" data-toggle="modal" data-target="#modal-xl" @click="Temizle()">
                  <i class="fa fa-plus"></i> Özellik Değeri Ekle
                </button>
              </div>
              <div class="col-4"><h3 class=""><b>Özellik Değerleri</b> </h3> </div>
              <div class="col-3"></div>
            </div>
          </div>
          <!-- /.card-header -->
          <div class="card-body">

            <table id="example1" class="table table-bordered table-striped">
              <thead>
                <tr>
                  <th>Özellik</th>
                  <th>Değer</th>
                  <th>Birim</th>
                  <th>Aktif</th>
                  <th></th>
                </tr>
              </thead>
              <tbody>
                <tr v-for="(n,index) in OzellikDegerList">
                  <td>{{n.VIEWNAME}}</td>
                  <td>{{n.VALUE}}</td>
                  <td>{{n.BIRIM_ADI}}</td>
                  <td>{{n.ACTIVE==true?'Aktif':'Pasif'}}</td>
                  <td>
                    <a class="btn btn-danger btn-sm sil text-white" @click="Delete(n.ID,index)"><i class="fas fa-trash"></i>Sil</a>
                    <a class="btn btn-info btn-sm edit text-white" data-toggle="modal" data-target="#modal-xl" @click="Edit(n.ID,index)"><i class="fas fa-edit"></i>Güncelle</a>
                  </td>
                </tr>

              </tbody>

            </table>
          </div>

        </div>


      </div>

      <div class="modal fade" id="modal-xl">
        <div class="modal-dialog modal-xl">
          <div class="modal-content">
            <div class="modal-header">
              <h4 class="modal-title">Özellikler</h4>
              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                <span aria-hidden="true">&times;</span>
              </button>
            </div>
            <div class="modal-body">
              <div class="row">
                <!-- left column -->
                <div class="col-md-12">
                  <!-- general form elements -->
                  <div class="card card-info">
                    <div class="card-header">
                      <h3 class="card-title"> {{ model.ID==null?"Özellik Değeri Ekle":"Özellik Değeri Düzenle" }}</h3>
                    </div>
                    <div class="">
                      <div class="card-body">
                        <div class="form-group">


                          <input type="hidden" v-model="model.ID" class="form-control" placeholder="ID">
                          <label for="exampleInputEmail1">Özellik</label>
                          <select class="custom-select" v-model="model.ATT_ID">

                            <option v-for="(n) in OzellikList" v-bind:value="n.ATT_ID">
                              {{n.VIEWNAME}}
                            </option>
                          </select>
                        </div>
                        <div class="form-group">
                          <label for="exampleInputEmail1">Değer</label>
                          <input type="text" v-model="model.VALUE" class="form-control" placeholder="Değer">
                        </div>
                        <div class="form-group">
                          <label for="exampleInputEmail1">Birim</label>

                          <select class="custom-select" v-model="model.BIRIM_ID">
                            <option v-for="(n) in BirimList" v-bind:value="n.Key">
                              {{n.Value}}
                            </option>
                          </select>
                        </div>
                        <div class="form-group">
                          <label for="exampleInputEmail1">Aktiflik</label><br />
                          <input type="checkbox" v-model="model.ACTIVE">
                        </div>


                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class="modal-footer justify-content-between">
              <button type="button" class="btn btn-danger" data-dismiss="modal">Kapat</button>
              <button type="button" class="btn btn-info" v-on:click="(model.ID==null?Save():Update())">Kaydet</button>
            </div>
          </div>

        </div>
      </div>
    </div>

  </div>
</template>

<script>
  import * as config from '@/assets/config.js';

  export default {

    name: 'AttributesValue',
    data() {
      return {
        model: {
          //ID: 0,
          //ATT_ID: "",
          //VIEWNAME: "",
          //VALUE: "",
          //ACTIVE: true,
          //BIRIM_ID: "",
          //BIRIM_ADI: ""
        },
        OzellikList: [],
        BirimList: [],
        OzellikDegerList: [],
      }
    },
    created() {
      this.ddl_Birimler();
      this.ddl_Attributes();
      this.List();
    },
    mounted: function () {

    },
    filters: {
    },
    computed:
    {
    },
    methods:
    {

      async Temizle() {

        this.model = {};
      },
      async Save() {
        try {
          const options = {
            method: 'POST',
            headers: {
              'Content-Type': 'application/json',
            },
            body: JSON.stringify(this.model),
          };

          const res = await fetch(config.API_LOCATION + "AttributesValue", options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == "OK") {
            this.List();
            this.$dialog.alert("Eklendi");
          }

        } catch (err) {
          console.log(err.message);
        }
      },
      async Edit(ID) {

        const options =
        {
          method: 'PUT',
          headers: {
            'Content-Type': 'application/json',
          },
        };
        try {
          const res = await fetch(config.API_LOCATION + "AttributesValue?ID=" + ID, options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          this.model = data;

        } catch (err) {
          console.log(err.message);

        }
      },
      async Update() {
        try {
          const options =
          {
            method: 'PATCH',
            headers: {
              'Content-Type': 'application/json',
            },
            body: JSON.stringify(this.model),
          };


          const res = await fetch(config.API_LOCATION + "AttributesValue", options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == "OK") {
            this.List();
            this.$dialog.alert("Bilgiler güncellendi");
            return;
          }
        }
        catch (err) {
          console.log(err.message);
        }
      },
      async ddl_Attributes() {
        try {
          const res = await fetch(config.API_LOCATION + "AttributesValue/ddl_Attributes");
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          this.OzellikList = data;
        } catch (err) {
          console.log(err.message);

        }
      },
      async ddl_Birimler() {
        try {
          const res = await fetch(config.API_LOCATION + "AttributesValue/ddl_Birimler");
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          this.BirimList = data;
        }
        catch (err) {
          console.log(err.message);
        }
      },

      async List() {
        try {

          const options = {
            method: 'GET',
            headers: {
              'Content-Type': 'application/json',
            },
            //body: JSON.stringify(update),
          };
          const res = await fetch(config.API_LOCATION + "AttributesValue", options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data.length > 0) {
            this.OzellikDegerList = data;

          }

          setTimeout(
            function () {
              $('#example1').dataTable({
                "pageLength": 50,
                "bProcessing": true,
                "responsive": true,
                'bPaginate': true,
                'bLengthChange': false,
                'bFilter': true,
                'bSort': false,
                'bInfo': false,
                "destroy": true,
                'processing': true,
                'aaSorting': [[0, 'desc']],
                "initComplete": function () {
                  //  console.log("yükleniyooorrr");
                  setTimeout(function () {
                    $('#preloader1').remove();
                    $('#preloader').remove();
                  }, 200)
                },
                oLanguage: {
                  "sSearch": "Ara:",
                  "oPaginate": {
                    "sPrevious": "Önceki",
                    "sNext": "Sonraki",
                    "sFirst": "İlk",
                    "sLast": "Son"
                  },
                  "sEmptyTable": "Herhangi Bir Veri Bulunamadı",
                },
              });

            }
            , 1000);
        } catch (err) {
          console.log(err.message);
        }
      },
      async Delete(ID, index)
      {
        try {

          const options = {
            method: 'DELETE',
            headers: {
              'Content-Type': 'application/json',
            },
          };
          const res = await fetch(config.API_LOCATION + "AttributesValue?ID=" + ID, options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == "OK") {
            this.OzellikDegerList.splice(index, 1);

            this.$dialog.alert('Kayıt silindi!');
          }
          else {
            this.$dialog.alert("Hata Oluştu");
          }
        } catch (err) {
          console.log(err.message);
          alert("Hata Oluştu");
        }
      }

    }
  }
</script>

<style scoped>
  h1, h2 {
    font-weight: normal;
  }

  ul {
    list-style-type: none;
    padding: 0;
  }

  li {
    display: inline-block;
    margin: 0 10px;
  }

  a {
    color: #42b983;
  }
</style>
