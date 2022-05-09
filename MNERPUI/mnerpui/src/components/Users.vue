<template>
  <div class="content-wrapper">
    <div class="container-fluid">
      <div class="col-12">
        <div class="card mt-2">
          <div class="card-header">
            <div class="row">
              <div class="col-5">
                <button type="button" class="btn btn-info btn-sm" data-toggle="modal" data-target="#modal-xl" @click="Temizle()">
                  <i class="fa fa-plus"></i> Kullanıcı Ekle
                </button>
              </div>
              <div class="col-4"><h3 class=""><b>Kullanıcılar</b> </h3> </div>
              <div class="col-3"></div>
            </div>
          </div>
          <!-- /.card-header -->
          <div class="card-body">

            <table id="example1" class="table table-bordered table-striped">
              <thead>
                <tr>
                  <th>Ad</th>
                  <th>Soyad</th>
                  <th>Email</th>
                  <th>Kullanıcı Adı</th>
                  <th>Şifre</th>
                  <th></th>
                </tr>
              </thead>
              <tbody>
                <tr v-for="(n,index) in UserList">
                  <td>{{n.NAME}}</td>
                  <td>{{n.SURNAME}}</td>
                  <td>{{n.EMAIL}}</td>
                  <td>{{n.USERN}}</td>
                  <td>{{n.PASS}}</td>
                  <td>
                    <a class="btn btn-danger btn-sm sil text-white" @click="Delete(n.USR_ID,index)"><i class="fas fa-trash"></i>Sil</a>
                    <a class="btn btn-info btn-sm edit text-white" data-toggle="modal" data-target="#modal-xl" @click="Edit(n.USR_ID,index)"><i class="fas fa-edit"></i>Güncelle</a>
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
              <h4 class="modal-title">Kullanıcılar</h4>
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
                      <h3 class="card-title"> {{ model.USR_ID==null?"Kullanıcı Ekle":"Kullanıcı Düzenle" }}</h3>
                    </div>
                    <div class="">
                      <div class="card-body">
                        <div class="form-group">
                          <label for="exampleInputEmail1">Adı</label>
                          <input type="hidden" v-model="model.USR_ID" class="form-control" placeholder="USR_ID">
                          <input type="text" v-model="model.NAME" class="form-control" placeholder="Ad">
                        </div>
                        <div class="form-group">
                          <label for="exampleInputEmail1">Soyadı</label>
                          <input type="text" v-model="model.SURNAME" class="form-control" placeholder="Soyad">
                        </div>
                        <div class="form-group">
                          <label for="exampleInputEmail1">Email</label>
                          <input type="text" v-model="model.EMAIL" class="form-control" placeholder="Şifre">
                        </div>
                        <div class="form-group">
                          <label for="exampleInputEmail1">Kullanıcı Adı</label>
                          <input type="text" v-model="model.USERN" class="form-control" placeholder="Kullanıcı Adı">
                        </div>

                        <div class="form-group">
                          <label for="exampleInputEmail1">Şifre</label>
                          <input type="text" v-model="model.PASS" class="form-control" placeholder="Şifre">
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class="modal-footer justify-content-between">
              <button type="button" class="btn btn-danger" data-dismiss="modal">Kapat</button>
              <button type="button" class="btn btn-info" v-on:click="(model.USR_ID==null?Save():Update())">Kaydet</button>
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

    name: 'Users',
    data() {
      return {
        model: {
          USR_ID: null,
          NAME: '',
          SURNAME: '',
          EMAIL: '',
          PASS: '',
          Hash: '',
          USERN: '',
        },


        UserList: [],
      }
    },
    created() {

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
      async Save()
      {
        try
        {
          const options = {
            method: 'POST',
            headers: {
              'Content-Type': 'application/json',
            },
            body: JSON.stringify(this.model),
          };
       
          const res = await fetch(config.API_LOCATION + "USERS", options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == "OK")
          {
            this.List();
            alert("Eklendi");
          }

        } catch (err) {
          console.log(err.message);
         

        }
      },
      async Edit(USR_ID)
      {

        const options = {
          method: 'PUT',
          headers: {
            'Content-Type': 'application/json',
          },
        };
        try
        {
          const res = await fetch(config.API_LOCATION + "USERS?ID=" + USR_ID, options);
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
      async Update()
      {
        try {
          const options = {
            method: 'PATCH',
            headers: {
              'Content-Type': 'application/json',
            },
            body: JSON.stringify(this.model),
          };

          const res = await fetch(config.API_LOCATION + "USERS", options);
          if (!res.ok)
          {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == "OK")
          {
            this.List();
            alert("Kullanıcı bilgileri kaydedildi");
            return;
          }
        } catch (err) {
          console.log(err.message);
   
        }
      },
      async List()
      {
        try {
          const options = {
            method: 'GET',
            headers: {
              'Content-Type': 'application/json',
            },
            //body: JSON.stringify(update),
          };
          const res = await fetch(config.API_LOCATION + "USERS", options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data.length > 0) {
            this.UserList = data;
           
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
        } catch (err)
        {
          console.log(err.message);
        }
      },
      async Delete(USR_ID, index)
      {
        try {

          const options = {
            method: 'DELETE',
            headers: {
              'Content-Type': 'application/json',
            },
        
          };
          const res = await fetch(config.API_LOCATION + "USERS?ID=" + USR_ID, options);
          if (!res.ok)
          {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == "OK")
          {
            this.UserList.splice(index, 1)
            alert("Kullanıcı bilgileri silindi");
          }
          else
          {
            alert("Hata Oluştu");
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
