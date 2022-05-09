<template>
  <div class='content-wrapper'>
    <div class='container-fluid'>
      <div class='col-12'>
        <div class='card mt-2'>
          <div class='card-header'>
            <div class='row'>
              <div class='col-5'>
                <button type='button' class='btn btn-info btn-sm' data-toggle='modal' data-target='#modal-xl' @click='Temizle()'>
                  <i class='fa fa-plus'></i> CARIKISILER Ekle
                </button>
              </div>
              <div class='col-4'><h3 class=''><b>CARIKISILER</b> </h3> </div>
              <div class='col-3'></div>
            </div>
          </div>
          <!-- /.card-header -->
          <div class='card-body'>

            <table id='example1' class='table table-bordered table-striped'>
              <thead>
                <tr><th>Kisi_ID</th>
<th>CDATE</th>
<th>UDATE</th>
<th>USR_ID</th>
<th>CUSR_ID</th>
<th>CARI_ID</th>
<th>ADI</th>
<th>SOYADI</th>
<th>TELEFON1</th>
<th>TELEFON2</th>
<th>TELEFON3</th>
<th>EMALIL</th>
<th>POZISYON</th>

                  <th></th>
                </tr>
              </thead>
              <tbody>
                <tr v-for='(n,index) in CARIKISILERList'>
  <td>{{n.Kisi_ID}}</td>
  <td>{{n.CDATE}}</td>
  <td>{{n.UDATE}}</td>
  <td>{{n.USR_ID}}</td>
  <td>{{n.CUSR_ID}}</td>
  <td>{{n.CARI_ID}}</td>
  <td>{{n.ADI}}</td>
  <td>{{n.SOYADI}}</td>
  <td>{{n.TELEFON1}}</td>
  <td>{{n.TELEFON2}}</td>
  <td>{{n.TELEFON3}}</td>
  <td>{{n.EMALIL}}</td>
  <td>{{n.POZISYON}}</td>

                  <td>
                    <a class='btn btn-danger btn-sm sil text-white' @click='Delete(n.Kisi_ID,index)'><i class='fas fa-trash'></i>Sil</a>
                    <a class='btn btn-info btn-sm edit text-white' data-toggle='modal' data-target='#modal-xl' @click='Edit(n.Kisi_ID,index)'><i class='fas fa-edit'></i>Güncelle</a>
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
              <h4 class='modal-title'>CARIKISILER</h4>
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
                      <h3 class='card-title'> {{ model.Kisi_ID==null?'CARIKISILER Ekle':'CARIKISILER Düzenle' }}</h3>
                    </div>
                    <div class=''>
                      <div class='card-body'>
                      
                    

    <div class='form-group'>
                          <label for='Kisi_ID'>Kisi_ID</label>
                          <input type='text' v-model='model.Kisi_ID' class='form-control' placeholder='Kisi_ID'>
                        </div>
    <div class='form-group'>
                          <label for='CDATE'>CDATE</label>
                          <input type='text' v-model='model.CDATE' class='form-control' placeholder='CDATE'>
                        </div>
    <div class='form-group'>
                          <label for='UDATE'>UDATE</label>
                          <input type='text' v-model='model.UDATE' class='form-control' placeholder='UDATE'>
                        </div>
    <div class='form-group'>
                          <label for='USR_ID'>USR_ID</label>
                          <input type='text' v-model='model.USR_ID' class='form-control' placeholder='USR_ID'>
                        </div>
    <div class='form-group'>
                          <label for='CUSR_ID'>CUSR_ID</label>
                          <input type='text' v-model='model.CUSR_ID' class='form-control' placeholder='CUSR_ID'>
                        </div>
    <div class='form-group'>
                          <label for='CARI_ID'>CARI_ID</label>
                          <input type='text' v-model='model.CARI_ID' class='form-control' placeholder='CARI_ID'>
                        </div>
    <div class='form-group'>
                          <label for='ADI'>ADI</label>
                          <input type='text' v-model='model.ADI' class='form-control' placeholder='ADI'>
                        </div>
    <div class='form-group'>
                          <label for='SOYADI'>SOYADI</label>
                          <input type='text' v-model='model.SOYADI' class='form-control' placeholder='SOYADI'>
                        </div>
    <div class='form-group'>
                          <label for='TELEFON1'>TELEFON1</label>
                          <input type='text' v-model='model.TELEFON1' class='form-control' placeholder='TELEFON1'>
                        </div>
    <div class='form-group'>
                          <label for='TELEFON2'>TELEFON2</label>
                          <input type='text' v-model='model.TELEFON2' class='form-control' placeholder='TELEFON2'>
                        </div>
    <div class='form-group'>
                          <label for='TELEFON3'>TELEFON3</label>
                          <input type='text' v-model='model.TELEFON3' class='form-control' placeholder='TELEFON3'>
                        </div>
    <div class='form-group'>
                          <label for='EMALIL'>EMALIL</label>
                          <input type='text' v-model='model.EMALIL' class='form-control' placeholder='EMALIL'>
                        </div>
    <div class='form-group'>
                          <label for='POZISYON'>POZISYON</label>
                          <input type='text' v-model='model.POZISYON' class='form-control' placeholder='POZISYON'>
                        </div>


                        
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class='modal-footer justify-content-between'>
              <button type='button' class='btn btn-danger' data-dismiss='modal'>Kapat</button>
              <button type='button' class='btn btn-info' v-on:click='(model.Kisi_ID==null?Save():Update())'>Kaydet</button>
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

    name: 'CARIKISILER',
    data() {
      return {
        model: {
Kisi_ID:null,
       CDATE:'',
UDATE:'',
USR_ID:'',
CUSR_ID:'',
CARI_ID:'',
ADI:'',
SOYADI:'',
TELEFON1:'',
TELEFON2:'',
TELEFON3:'',
EMALIL:'',
POZISYON:'',

        },
        CARIKISILERList: [],
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

      async Temizle()
      {
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
       
          const res = await fetch(config.API_LOCATION + 'CARIKISILER', options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == 'OK')
          {
            this.List();
            alert('Eklendi');
          }

        } catch (err) {
          console.log(err.message);
        }
      },
      async Edit(Kisi_ID)
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
          const res = await fetch(config.API_LOCATION + 'CARIKISILER?ID=' + Kisi_ID, options);
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

          const res = await fetch(config.API_LOCATION + 'CARIKISILER', options);
          if (!res.ok)
          {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == 'OK')
          {
            this.List();
            alert('bilgiler güncellendi');
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
          const res = await fetch(config.API_LOCATION + 'CARIKISILER', options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data.length > 0) {
            this.CARIKISILERList = data;
           
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
        } catch (err)
        {
          console.log(err.message);
        }
      },
      async Delete(Kisi_ID, index)
      {
        try {

          const options = {
            method: 'DELETE',
            headers: {'Content-Type': 'application/json',},
          };
          const res = await fetch(config.API_LOCATION + 'CARIKISILER?ID=' + Kisi_ID, options);
          if (!res.ok)
          {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == 'OK')
          {
            this.CARIKISILERList.splice(index, 1)
            alert('Kayıt silindi');
          }
          else
          {
            alert('Hata Oluştu');
          }
        } catch (err)
        {
          console.log(err.message);
          alert('Hata Oluştu');
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

