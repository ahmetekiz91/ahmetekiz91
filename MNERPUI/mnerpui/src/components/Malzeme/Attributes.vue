
<template>
  <div class="content-wrapper">
    <div class="container-fluid">
      <div class="col-12">
        <div class="card mt-2">
          <div class="card-header">
            <div class="row">
              <div class="col-5">
                <button type="button" class="btn btn-info btn-sm" data-toggle="modal" data-target="#modal-xl" @click="Temizle()">
                  <i class="fa fa-plus"></i> Özellik Ekle
                </button>
              </div>
              <div class="col-4"><h3 class=""><b>Malzeme Özellikler</b> </h3> </div>
              <div class="col-3"></div>
            </div>
          </div>
          <!-- /.card-header -->
          <div class="card-body">
            <table id='example1' class='table table-bordered table-striped'>
              <thead>
                <tr>
       
                  <th>KOD</th>
                  <th>TANIM</th>
                  <th>AD</th>
                  <th>VERİ TİPİ</th>

                  <th></th>
                </tr>
              </thead>
              <tbody>
                <tr v-for='(n,index) in OzellikList'>
      
                  <td>{{n.ATTCODE}}</td>
                  <td>{{n.ATTDESCRIBTION}}</td>
                  <td>{{n.VIEWNAME}}</td>
                  <td>{{n.SYNTAX}}</td>

                  <td>
                    <a class='btn btn-danger btn-sm sil text-white' @click='Delete(n.ATT_ID,index)'><i class='fas fa-trash'></i>Sil</a>
                    <a class='btn btn-info btn-sm edit text-white' data-toggle='modal' data-target='#modal-xl' @click='Edit(n.ATT_ID,index)'><i class='fas fa-edit'></i>Güncelle</a>
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
                      <h3 class="card-title"> {{ model.ATT_ID==null?"Özellik Ekle":"Özellik Düzenle" }}</h3>
                    </div>
                    <div class="">
                      <div class="card-body">
                        <div class="form-group">
                        
                          <label for="exampleInputEmail1">Özellik Kodu</label>
                          <input type="hidden" v-model="model.ATT_ID" class="form-control" placeholder="ATT_ID">
                          <input type="text" v-model="model.ATTCODE" class="form-control" placeholder="Ad">
                        </div>
                        <div class="form-group">
                          <label for="exampleInputEmail1">Özellik Tanımı</label>
                          <input type="text" v-model="model.ATTDESCRIBTION" class="form-control" placeholder="Soyad">
                        </div>
                        <div class="form-group">
                          <label for="exampleInputEmail1">Ekran Adı</label>
                          <input type="text" v-model="model.VIEWNAME" class="form-control" placeholder="Şifre">
                        </div>
                        <div class="form-group">
                          <label for="exampleInputEmail1">Veri Türü</label>
                          <input type="text" v-model="model.SYNTAX" class="form-control" placeholder="Kullanıcı Adı">
                        </div>
                                                
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class="modal-footer justify-content-between">
              <button type="button" class="btn btn-danger" data-dismiss="modal" @click="handleClick()">Kapat</button>
              <button type="button" class="btn btn-info" v-on:click="(model.ATT_ID==null?Save():Update())">Kaydet</button>
            </div>
          </div>

        </div>
      </div>
    </div>

  </div>
</template>

<script>

  import * as config from '@/assets/config.js';
//npm i -S vuejs-dialog
  export default {

    name: 'Attributes',
    data() {
      return {
        model: {
          ATT_ID: null,
          ATTCODE: '',
          ATTDESCRIBTION: '',
          VIEWNAM:'',
          SYNTAX:''
        },
        OzellikList: [],
      }
    },
    created() {

      this.List();
    },
    mounted: function ()
    {

    },
    filters: {
    },
    computed:
    {
  
      //bindings()
      //{
      //  return {
          
      //    data: this.OzellikList,
      //    actionMode: "multiple",
      //    columns: [{
      //      key: "ATTCODE",
      //      title: "Kod",
      //      sortable: false,
      //      searchable: false,
      //      index: 0
      //    },
      //      {
      //        key: "ATTDESCRIBTION",
      //        title: "Açıklama",
      //        sortable: false,
      //        searchable: false,
      //        index: 0
      //      },
      //      {
      //        key: "VIEWNAME",
      //        title: "Özellik Adı",
      //        sortable: false,
      //        searchable: false,
      //        index: 0

      //      },
      //      {
      //        key: "SYNTAX",
      //        title: "Veri Tipi",
      //        sortable: false,
      //        searchable: false,
      //        index: 0
      //      },
      //       {
      //      key: "permissions",
      //      /* custom function sort users by which user has more permissions */
      //      sortingFunction: function(a, b) {
      //          // permissions is an array
      //          return a.permissions.length - b.permissions.length;
      //      },
           
      //      component: TableFooter,
      //  }
      //    ],
          
      //    showPagination: true,
      //    showEntriesInfo: false,
      //    showDownloadButton: false,
      //    showPerPage: false,
      //    text: {
      //      PerPageText: "Number of users per page :entries",
      //      infoText: "Displaying :first to :last of :total users",
      //      emptyTableText: "No users found :(",
      //      searchText: "Ara",
      //      nextButtonText:	"İleri",
      //      previousButtonText:	"Geri",
      //      paginationSearchText: "Sayfaya git",
      //      paginationSearchButtonText:	"git"
      //    },   
      //  }
      //}
    },
    methods:
    {
   handleClick(){
     this.$dialog.alert('Request completed!').then(function(dialog) {});
//  this.$dialog
//   .confirm('Please confirm to continue')
//   .then(function(dialog) {
//     console.log('Clicked on proceed');
//   })
//   .catch(function() {
//     console.log('Clicked on cancel');
//   })
      // this.$confirm(
      //   {
      //     message: 'Are you sure?',
      //     button: {
      //       no: 'No',
      //       yes: 'Yes'
      //     },
      
      //     callback: confirm => {
      //       if (confirm) {
      //         alert("merhaba")
      //       }
      //     }
      //   }
      // )
    },
      async Temizle()
      {
        this.model = {};
      },
      async initDatatable()
      {
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
              "destroy": true,
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
       
          const res = await fetch(config.API_LOCATION + "Attribute", options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == "OK")
          {
            this.List();
           this.$dialog.alert('Eklendi!').then(function(dialog) {});
          }

        } catch (err) {
          console.log(err.message);
        }
      },
      async Edit(ATT_ID)
      {

        const options =
        {
          method: 'PUT',
          headers: {
            'Content-Type': 'application/json',
          },
        };
        try
        {
          const res = await fetch(config.API_LOCATION + "Attribute?ID=" + ATT_ID, options);
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

          const res = await fetch(config.API_LOCATION + "Attribute", options);
          if (!res.ok)
          {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == "OK")
          {
            this.List();
          
            this.$dialog.alert('Bilgiler Güncellendi!').then(function (dialog) { });
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
          };
          const res = await fetch(config.API_LOCATION + "Attribute", options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data.length > 0) {
            this.OzellikList = data;
            this.initDatatable();
          }
        
        } catch (err)
        {
          console.log(err.message);
        }
      },
      async Deletemethod(ATT_ID,index)
      {
       
        try
        {
          const options = {
            method: 'DELETE',
            headers: { 'Content-Type': 'application/json', },
          };
          const res = await fetch(config.API_LOCATION + "Attribute?ID=" + ATT_ID, options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == "OK")
          {
            this.OzellikList.splice(index, 1);
            this.$dialog.alert('Bilgiler silindi!')
          }
          else {
            this.$dialog.alert('Hata oluştu!')
          }
        } catch (e) {

        }
      },
      async Delete(ATT_ID, index)
      {

        this.$dialog.confirm('Bu kaydı silmek istediğinizden emin misiniz', {
          okText: "Evet",
          cancelText: 'Hayır'
        }).then((dialog) => { // change function to arrow syntax
          this.Deletemethod(ATT_ID, index); 
        })
          .catch(function(err) {
            //this.$dialog.alert('Hata oluştu!');
            console.log(err.message);
          })
      }

    }
  }
</script>


