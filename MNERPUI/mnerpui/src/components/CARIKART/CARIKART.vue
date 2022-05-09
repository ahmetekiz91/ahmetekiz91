<template>
  <div class='content-wrapper'>
    <div class='container-fluid'>
      <div class='col-12'>
        <div class='card mt-2'>
          <div class='card-header'>
            <div class='row'>
              <div class='col-5'>
                <button type='button' class='btn btn-info btn-sm' data-toggle='modal' data-target='#modal-xl' @click='Temizle()'>
                  <i class='fa fa-plus'></i> Carikart Ekle
                </button>
              </div>
              <div class='col-4'><h3 class=''><b>Carikartlar</b> </h3> </div>
              <div class='col-3'></div>
            </div>
          </div>
          <!-- /.card-header -->
          <div class='card-body'>

            <table id='example1' class='table table-bordered table-striped'>
              <thead>
                <tr>

                  <th>Cari Kodu</th>
                  <th>Cari Ünvan</th>
                  <th>Cari Grup</th>
                  <th>Telefon</th>
                  <th>Email</th>
                  <th>Fax</th>
                  <th>Ülke</th>
                  <th>Plasiyer</th>
                  <th>Durum</th>
                  <th></th>
                </tr>
              </thead>
              <tbody>
                <tr v-for='(n,index) in CARIKARTList'>
                  <td>{{n.CARI_KODU}}</td>
                  <td>{{n.CARI_UNVAN}}</td>
                  <td>{{n.GRUPADI}}</td>
                  <td>{{n.TEL1}}</td>
                  <td>{{n.EMAIL}}</td>
                  <td>{{n.FAX}}</td>
                  <td>{{n.ULKE_ADI}}</td>
                  <td>{{n.PLASIYER_ADI}}</td>
                  <td>{{n.ACTIVE==true?"Aktif":"Pasif"}}</td>
                  <td>
                    <a class='btn btn-danger btn-sm sil text-white' @click='Delete(n.CARI_ID,index)'><i class='fas fa-trash'></i>Sil</a>
                    <a class='btn btn-info btn-sm edit text-white' data-toggle='modal' data-target='#modal-xl' @click='Edit(n.CARI_ID,index)'><i class='fas fa-edit'></i>Güncelle</a>
                  </td>
                </tr>

              </tbody>

            </table>
          </div>

        </div>


      </div>

      <div class='modal fade' id='modal-xl'>
        <div class='modal-dialog modal-xl'>
          <div class='modal-content'>
            <div class='modal-header'>
              <button type='button' class='close' data-dismiss='modal' aria-label='Close'>
                <span aria-hidden='true'>&times;</span>
              </button>
            </div>
            <div class='modal-body'>
              <div class='row'>
                <!-- left column -->
                <div class='col-md-12'>
                  <!-- general form elements -->
                  <div class='card card-info'>
                    <div class='card-header'>
                      <h3 class='card-title'> {{ model.CARI_ID==null?'Carikart Ekle':'Carikart Düzenle' }}</h3>
                    </div>
                    <div class=''>
                      <div class='card-body'>
                        <div class="row">
                          <div class="col-sm-6">
                            <div class='form-group'>
                              <label for='CARI_KODU'>Cari Kodu</label>
                              <input type='hidden' v-model='model.CARI_ID' class='form-control' placeholder='CARI_ID'>
                              <input type='text' v-model='model.CARI_KODU' class='form-control'>
                            </div>
                          </div>
                          <div class="col-sm-6">

                            <div class='form-group'>
                              <label for='CARI_UNVAN'>Cari Ünvan</label>
                              <input type='text' v-model='model.CARI_UNVAN' class='form-control'/>
                            </div>
                          </div>
                          <div class="col-sm-6">
                            <div class='form-group'>
                              <label for='GRUPID'>Cari Grup</label>
                              <select class="custom-select" v-model="model.GRUPID">
                                <option v-for="(n) in GrupList" v-bind:value="n.Key">
                                  {{n.Value}}
                                </option>
                              </select>
                            </div>
                          </div>
                          <div class="col-sm-2">
                            <div class='form-group'>
                              <label for='ALICI'>Alıcı</label><br />
                              <input type='checkbox' v-model='model.ALICI'>
                            </div>
                          </div>
                          <div class="col-sm-2">
                            <div class='form-group'>
                              <label for='SATICI'>Satıcı</label><br />
                              <input type='checkbox' v-model='model.SATICI'>
                            </div>
                          </div>
                          <div class="col-sm-2">
                            <div class='form-group'>
                              <label for='ACTIVE'>Aktiflik</label><br />
                              <input type='checkbox' v-model='model.ACTIVE'>
                            </div>
                          </div>
                          <div class="col-sm-6">
                            <div class='form-group'>
                              <label for='VERGINO'>Vergi No</label>
                              <input type='text' v-model='model.VERGINO' class='form-control'>
                            </div>
                          </div>
                          <div class="col-sm-6">
                            <div class='form-group'>
                              <label for='VERGIDAIRESI'>Vergi Dairesi</label>
                              <input type='text' v-model='model.VERGIDAIRESI' class='form-control' >
                            </div>
                          </div>

                        </div>
                        <h4><b>İletişim</b></h4>
                        <div class="row">
                          <div class="col-sm-6">
                            <div class='form-group'>
                              <label for='TEL1'>Telefon</label>
                              <input type='text' v-model='model.TEL1' class='form-control' >
                            </div>
                          </div>
                          <div class="col-sm-6">
                            <div class='form-group'>
                              <label for='EMAIL'>Email</label>
                              <input type='text' v-model='model.EMAIL' class='form-control'>
                            </div>
                          </div>

                          <div class="col-sm-6">
                            <div class='form-group'>
                              <label for='FAX'>Fax</label>
                              <input type='text' v-model='model.FAX' class='form-control'>
                            </div>
                          </div>
                          <div class="col-sm-6">
                            <div class='form-group'>
                              <label for='WEB'>Web Adresi</label>
                              <input type='text' v-model='model.WEB' class='form-control'>
                            </div>
                          </div>
                          <div class="col-sm-6">
                            <div class='form-group'>
                              <label for='ULKE_ID'>Ülkeler</label>
                              <select class="custom-select" v-model="model.ULKE_ID">
                                <option v-for="(n) in UlkeList" v-bind:value="n.Key">
                                  {{n.Value}}
                                </option>
                              </select>

                            </div>
                          </div>
                          <div class="col-sm-6">
                            <div class='form-group'>
                              <label for='PLASIYER_ID'>Satış Temsilcisi</label>
                              <select class="custom-select" v-model="model.PLASIYER_ID">

                                <option v-for="(n) in PlasiyerList" v-bind:value="n.Key">
                                  {{n.Value}}
                                </option>
                              </select>

                            </div>
                          </div>
                     
                          </div>

                          <div class="row">
                            <div class="col-sm-6">
                              <div class='form-group'>
                                <label for='SPECODE1'>Özelkod 1</label>
                                <input type='text' v-model='model.SPECODE1' class='form-control'>
                              </div>
                            </div>
                            <div class="col-sm-6">
                              <div class='form-group'>
                                <label for='SPECODE2'>Özelkod 2</label>
                                <input type='text' v-model='model.SPECODE2' class='form-control' >
                              </div>
                            </div>
                            <div class="col-sm-6">
                              <div class='form-group'>
                                <label for='SPECODE3'>Özelkod 3</label>
                                <input type='text' v-model='model.SPECODE3' class='form-control' >
                              </div>
                            </div>
                            <div class="col-sm-6">
                              <div class='form-group'>
                                <label for='SPECODE4'>Özelkod 4</label>
                                <input type='text' v-model='model.SPECODE4' class='form-control' >
                              </div>
                            </div>
                          </div>
                        </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class='modal-footer justify-content-between'>
              <button type='button' class='btn btn-danger' data-dismiss='modal'>Kapat</button>
              <button type='button' class='btn btn-primary' v-on:click='(model.CARI_ID==null?Save():Update())'>Kaydet</button>
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

    name: 'CARIKART',
    data() {
      return {
        model: {
          CARI_ID: null,
          CARI_KODU: '',
          CARI_UNVAN: '',
          ALICI: false,
          SATICI: false,
          SPECODE1: '',
          SPECODE2: '',
          SPECODE3: '',
          SPECODE4: '',
          SPECODE5: '',
          SPECODE6: '',
          SPECODE7: '',
          TEL1: '',
          TEL2: '',
          TEL3: '',
          EMAIL: '',
          FAX: '',
          FAX2: '',
          ULKE_ID: 0,
          ULKE_ADI:'',
          PLASIYER_ID: 0,
          PLASIYER_ADI:'',
          VERGINO: '',
          VERGIDAIRESI: '',
          WEB: '',
          GRUPID: 0,
          GRUPADI: '',
          ACTIVE: false,

        },
        CARIKARTList: [],
        UlkeList: [],
        PlasiyerList: [],
        GrupList: [],
      }
    },
    created() {
      this.ddl_CARIGRUPLAR();
      this.ddl_Plasiyerler();
      this.ddl_Ulkeler();
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
      async ddl_Ulkeler() {
        try {
          const res = await fetch(config.API_LOCATION + "Content/ddl_Ulkeler");
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          this.UlkeList = data;
        }
        catch (err) {
          console.log(err.message);
        }
      },
      async ddl_Plasiyerler() {
        try {
          const res = await fetch(config.API_LOCATION + "Content/ddl_Plasiyerler");
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          this.PlasiyerList = data;
        }
        catch (err) {
          console.log(err.message);
        }
      },
      async ddl_CARIGRUPLAR()
      {
        try {
          const res = await fetch(config.API_LOCATION + "Content/ddl_CARIGRUPLAR");
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          this.GrupList = data;
        }
        catch (err) {
          console.log(err.message);
        }
      },
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

          const res = await fetch(config.API_LOCATION + 'CARIKART', options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == 'OK') {
            this.List();
            this.$dialog.alert('Eklendi');
            return;
          }
          else {
            this.$dialog.alert('Hata Oluştu');
          }

        } catch (err) {
          console.log(err.message);
        }
      },
      async Edit(CARI_ID) {
        const options =
        {
          method: 'PUT',
          headers: {
            'Content-Type': 'application/json',
          },
        };
        try {
          const res = await fetch(config.API_LOCATION + 'CARIKART?ID=' + CARI_ID, options);
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
          const options = {
            method: 'PATCH',
            headers: {
              'Content-Type': 'application/json',
            },
            body: JSON.stringify(this.model),
          };

          const res = await fetch(config.API_LOCATION + 'CARIKART', options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == 'OK') {
            this.List();
            this.$dialog.alert('Bilgiler güncellendi');
            return;
          } else {
            this.$dialog.alert('Hata Oluştu');
          }
        } catch (err) {
          console.log(err.message);

        }
      },
      async List()
      {
        try
        {
          const options =
          {
            method: 'GET',
            headers: {
              'Content-Type': 'application/json',
            },
          };
          const res = await fetch(config.API_LOCATION + 'CARIKART', options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data.length > 0) {
            this.CARIKARTList = data;

          }
          setTimeout(
            function ()
            {
              $('#example1').dataTable({
                'pageLength': 50,
                'bProcessing': true,
                'responsive': true,
                'bPaginate': true,
                'bLengthChange': false,
                'bFilter': true,
                'bSort': false,
                'destroy': true,
                'bInfo': false,
                'processing': true,
                'aaSorting': [[0, 'desc']],
                'initComplete': function () {
                  setTimeout(function () {
                    $('#preloader1').remove();
                    $('#preloader').remove();
                  }, 200)
                },
                oLanguage: {
                  'sSearch': 'Ara:',
                  'oPaginate': {
                    'sPrevious': 'Önceki',
                    'sNext': 'Sonraki',
                    'sFirst': 'İlk',
                    'sLast': 'Son'
                  },
                  'sEmptyTable': 'Herhangi Bir Veri Bulunamadı',
                },
              });

            }
            , 1000);
        } catch (err) {
          console.log(err.message);
        }
      },
      async Deletemethod(CARI_ID, index) {

        try {
          const options = {
            method: 'DELETE',
            headers: { 'Content-Type': 'application/json', },
          };
          const res = await fetch(config.API_LOCATION + 'CARIKART?ID=' + CARI_ID, options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == "OK") {
            this.CARIKARTList.splice(index, 1);
            this.$dialog.alert('Bilgiler silindi!')
          }
          else {
            this.$dialog.alert('Hata oluştu!')
          }
        } catch (e) {

        }
      },
      async Delete(CARI_ID, index) {
        this.$dialog.confirm('Bu kaydı silmek istediğinizden emin misiniz', {
          okText: "Evet",
          cancelText: 'Hayır'
        }).then((dialog) =>
        {
          this.Deletemethod(CARI_ID, index);
        })
          .catch(function (err) {
            //this.$dialog.alert('Hata oluştu!');
            console.log(err.message);
          })
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

  input[type="checkbox"] {
    transform: scale(2, 2);
  }
</style>

