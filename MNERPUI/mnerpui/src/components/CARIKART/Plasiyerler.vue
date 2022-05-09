<template>
  <div class='content-wrapper'>
    <div class='container-fluid'>
      <div class='col-12'>
        <div class='card mt-2'>
          <div class='card-header'>
            <div class='row'>
              <div class='col-5'>
                <button type='button' class='btn btn-info btn-sm' data-toggle='modal' data-target='#modal-xl' @click='Temizle()'>
                  <i class='fa fa-plus'></i> Plasiyerler Ekle
                </button>
              </div>
              <div class='col-4'><h3 class=''><b>Plasiyerler</b> </h3> </div>
              <div class='col-3'></div>
            </div>
          </div>
          <!-- /.card-header -->
          <div class='card-body'>

            <table id='example1' class='table table-bordered table-striped'>
              <thead>
                <tr>
                  <th>Adı</th>
                  <th>Soyadı</th>
                  <th>Telefon</th>
                  <th>Email</th>
                  <th></th>
                </tr>
              </thead>
              <tbody>
                <tr v-for='(n,index) in PlasiyerlerList'>
                  <td>{{n.PLADI}}</td>
                  <td>{{n.PLSOYADI}}</td>
                  <td>{{n.PLTEL}}</td>
                  <td>{{n.PLEMAIL}}</td>
                  <td>
                    <a class='btn btn-danger btn-sm sil text-white' @click='Delete(n.PLA_ID,index)'><i class='fas fa-trash'></i>Sil</a>
                    <a class='btn btn-info btn-sm edit text-white' data-toggle='modal' data-target='#modal-xl' @click='Edit(n.PLA_ID,index)'><i class='fas fa-edit'></i>Güncelle</a>
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
                      <h3 class='card-title'> {{ model.PLA_ID==null?'Plasiyerler Ekle':'Plasiyerler Düzenle' }}</h3>
                    </div>
                    <div class=''>
                      <div class='card-body'>
                        <div class='form-group'>
                          <input type='hidden' v-model='model.PLA_ID' class='form-control' placeholder='PLA_ID'>

                          <label for='PLADI'>Adı</label>
                          <input type='text' v-model='model.PLADI' class='form-control' placeholder='PLADI'>
                        </div>
                        <div class='form-group'>
                          <label for='PLSOYADI'>Soyadı</label>
                          <input type='text' v-model='model.PLSOYADI' class='form-control' placeholder='PLSOYADI'>
                        </div>
                        <div class='form-group'>
                          <label for='PLTEL'>Telefon</label>
                          <input type='text' v-model='model.PLTEL' class='form-control' placeholder='PLTEL'>
                        </div>
                        <div class='form-group'>
                          <label for='PLEMAIL'>Email</label>
                          <input type='text' v-model='model.PLEMAIL' class='form-control' placeholder='PLEMAIL'>
                        </div>



                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class='modal-footer justify-content-between'>
              <button type='button' class='btn btn-danger' data-dismiss='modal'>Kapat</button>
              <button type='button' class='btn btn-info' v-on:click='(model.PLA_ID==null?Save():Update())'>Kaydet</button>
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

    name: 'Plasiyerler',
    data() {
      return {
        model: {
          PLA_ID: null,
          USR_ID: '',
          CDATE: '',
          CUSR_ID: '',
          UDATE: '',
          PLADI: '',
          PLSOYADI: '',
          PLTEL: '',
          PLEMAIL: '',

        },
        PlasiyerlerList: [],
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
      async Save() {
        try {
          const options = {
            method: 'POST',
            headers: {
              'Content-Type': 'application/json',
            },
            body: JSON.stringify(this.model),
          };

          const res = await fetch(config.API_LOCATION + 'Plasiyerler', options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == 'OK') {
            this.List();
            this.$dialog.alert('Eklendi', { okText: "Tamam" });
          }
          else {
            this.$dialog.alert('Hata Oluştu', { okText: "Tamam" });
          }

        } catch (err) {
          console.log(err.message);
        }
      },
      async Edit(PLA_ID)
      {
        const options =
        {
          method: 'PUT',
          headers: {
            'Content-Type': 'application/json',
          },
        };
        try {
          const res = await fetch(config.API_LOCATION + 'Plasiyerler?ID=' + PLA_ID, options);
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

          const res = await fetch(config.API_LOCATION + 'Plasiyerler', options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == 'OK') {
            this.List();
            this.$dialog.alert('Bilgiler güncellendi',{okText: "Tamam"});
            return;
          } else {
            this.$dialog.alert('Hata Oluştu', { okText: "Tamam" });
          }
        } catch (err) {
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
          };
          const res = await fetch(config.API_LOCATION + 'Plasiyerler', options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data.length > 0) {
            this.PlasiyerlerList = data;

          }
          setTimeout(
            function () {
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
      async Deletemethod(PLA_ID, index)
      {

        try {
          const options = {
            method: 'DELETE',
            headers: { 'Content-Type': 'application/json', },
          };
          const res = await fetch(config.API_LOCATION + 'Plasiyerler?ID=' + PLA_ID, options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == "OK") {
            this.PlasiyerlerList.splice(index, 1);
            this.$dialog.alert('Bilgiler silindi!', { okText: "Tamam" })
          }
          else {
            this.$dialog.alert('Hata oluştu!', { okText: "Tamam" })
          }
        } catch (e) {

        }
      },
      async Delete(PLA_ID, index)
      {

        this.$dialog.confirm('Bu kaydı silmek istediğinizden emin misiniz?',
        {
          okText: "Evet",
          cancelText: 'Hayır'
        }).then((dialog) => {
          this.Deletemethod(PLA_ID, index);
        }).catch(function (err) {
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
</style>

