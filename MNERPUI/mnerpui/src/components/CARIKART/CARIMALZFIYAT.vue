<template>
  <div class='content-wrapper'>
    <div class='container-fluid'>
      <div class='col-12'>
        <div class='card mt-2'>
          <div class='card-header'>
            <div class='row'>
              <div class='col-5'>
                <button type='button' class='btn btn-info btn-sm' data-toggle='modal' data-target='#modal-xl' @click='Temizle()'>
                  <i class='fa fa-plus'></i> CARIMALZFIYAT Ekle
                </button>
              </div>
              <div class='col-4'><h3 class=''><b>CARIMALZFIYAT</b> </h3> </div>
              <div class='col-3'></div>
            </div>
          </div>
          <!-- /.card-header -->
          <div class='card-body'>

            <table id='example1' class='table table-bordered table-striped'>
              <thead>
                <tr><th>CARMALZFIY_ID</th>
<th>CDATE</th>
<th>CUSR_ID</th>
<th>MALZ_ID</th>
<th>MCAT_ID</th>
<th>CARI_ID</th>
<th>FIYAT</th>
<th>BRM_ID</th>
<th>DOV_ID</th>
<th>MIKTAR</th>
<th>UDATE</th>
<th>UUSR_ID</th>
<th>MBCD_ID1</th>
<th>MBCD_ID2</th>
<th>MBCD_ID1Deger</th>
<th>MBCD_ID2Deger</th>

                  <th></th>
                </tr>
              </thead>
              <tbody>
                <tr v-for='(n,index) in CARIMALZFIYATList'>
  <td>{{n.CARMALZFIY_ID}}</td>
  <td>{{n.CDATE}}</td>
  <td>{{n.CUSR_ID}}</td>
  <td>{{n.MALZ_ID}}</td>
  <td>{{n.MCAT_ID}}</td>
  <td>{{n.CARI_ID}}</td>
  <td>{{n.FIYAT}}</td>
  <td>{{n.BRM_ID}}</td>
  <td>{{n.DOV_ID}}</td>
  <td>{{n.MIKTAR}}</td>
  <td>{{n.UDATE}}</td>
  <td>{{n.UUSR_ID}}</td>
  <td>{{n.MBCD_ID1}}</td>
  <td>{{n.MBCD_ID2}}</td>
  <td>{{n.MBCD_ID1Deger}}</td>
  <td>{{n.MBCD_ID2Deger}}</td>

                  <td>
                    <a class='btn btn-danger btn-sm sil text-white' @click='Delete(n.CARMALZFIY_ID,index)'><i class='fas fa-trash'></i>Sil</a>
                    <a class='btn btn-info btn-sm edit text-white' data-toggle='modal' data-target='#modal-xl' @click='Edit(n.CARMALZFIY_ID,index)'><i class='fas fa-edit'></i>Güncelle</a>
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
              <h4 class='modal-title'>CARIMALZFIYAT</h4>
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
                      <h3 class='card-title'> {{ model.CARMALZFIY_ID==null?'CARIMALZFIYAT Ekle':'CARIMALZFIYAT Düzenle' }}</h3>
                    </div>
                    <div class=''>
                      <div class='card-body'>
                      
                    

    <div class='form-group'>
                          <label for='CARMALZFIY_ID'>CARMALZFIY_ID</label>
                          <input type='text' v-model='model.CARMALZFIY_ID' class='form-control' placeholder='CARMALZFIY_ID'>
                        </div>
    <div class='form-group'>
                          <label for='CDATE'>CDATE</label>
                          <input type='text' v-model='model.CDATE' class='form-control' placeholder='CDATE'>
                        </div>
    <div class='form-group'>
                          <label for='CUSR_ID'>CUSR_ID</label>
                          <input type='text' v-model='model.CUSR_ID' class='form-control' placeholder='CUSR_ID'>
                        </div>
    <div class='form-group'>
                          <label for='MALZ_ID'>MALZ_ID</label>
                          <input type='text' v-model='model.MALZ_ID' class='form-control' placeholder='MALZ_ID'>
                        </div>
    <div class='form-group'>
                          <label for='MCAT_ID'>MCAT_ID</label>
                          <input type='text' v-model='model.MCAT_ID' class='form-control' placeholder='MCAT_ID'>
                        </div>
    <div class='form-group'>
                          <label for='CARI_ID'>CARI_ID</label>
                          <input type='text' v-model='model.CARI_ID' class='form-control' placeholder='CARI_ID'>
                        </div>
    <div class='form-group'>
                          <label for='FIYAT'>FIYAT</label>
                          <input type='text' v-model='model.FIYAT' class='form-control' placeholder='FIYAT'>
                        </div>
    <div class='form-group'>
                          <label for='BRM_ID'>BRM_ID</label>
                          <input type='text' v-model='model.BRM_ID' class='form-control' placeholder='BRM_ID'>
                        </div>
    <div class='form-group'>
                          <label for='DOV_ID'>DOV_ID</label>
                          <input type='text' v-model='model.DOV_ID' class='form-control' placeholder='DOV_ID'>
                        </div>
    <div class='form-group'>
                          <label for='MIKTAR'>MIKTAR</label>
                          <input type='text' v-model='model.MIKTAR' class='form-control' placeholder='MIKTAR'>
                        </div>
    <div class='form-group'>
                          <label for='UDATE'>UDATE</label>
                          <input type='text' v-model='model.UDATE' class='form-control' placeholder='UDATE'>
                        </div>
    <div class='form-group'>
                          <label for='UUSR_ID'>UUSR_ID</label>
                          <input type='text' v-model='model.UUSR_ID' class='form-control' placeholder='UUSR_ID'>
                        </div>
    <div class='form-group'>
                          <label for='MBCD_ID1'>MBCD_ID1</label>
                          <input type='text' v-model='model.MBCD_ID1' class='form-control' placeholder='MBCD_ID1'>
                        </div>
    <div class='form-group'>
                          <label for='MBCD_ID2'>MBCD_ID2</label>
                          <input type='text' v-model='model.MBCD_ID2' class='form-control' placeholder='MBCD_ID2'>
                        </div>
    <div class='form-group'>
                          <label for='MBCD_ID1Deger'>MBCD_ID1Deger</label>
                          <input type='text' v-model='model.MBCD_ID1Deger' class='form-control' placeholder='MBCD_ID1Deger'>
                        </div>
    <div class='form-group'>
                          <label for='MBCD_ID2Deger'>MBCD_ID2Deger</label>
                          <input type='text' v-model='model.MBCD_ID2Deger' class='form-control' placeholder='MBCD_ID2Deger'>
                        </div>


                        
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class='modal-footer justify-content-between'>
              <button type='button' class='btn btn-danger' data-dismiss='modal'>Kapat</button>
              <button type='button' class='btn btn-info' v-on:click='(model.CARMALZFIY_ID==null?Save():Update())'>Kaydet</button>
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

    name: 'CARIMALZFIYAT',
    data() {
      return {
        model: {
CARMALZFIY_ID:null,
       CDATE:'',
CUSR_ID:'',
MALZ_ID:'',
MCAT_ID:'',
CARI_ID:'',
FIYAT:'',
BRM_ID:'',
DOV_ID:'',
MIKTAR:'',
UDATE:'',
UUSR_ID:'',
MBCD_ID1:'',
MBCD_ID2:'',
MBCD_ID1Deger:'',
MBCD_ID2Deger:'',

        },
        CARIMALZFIYATList: [],
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
       
          const res = await fetch(config.API_LOCATION + 'CARIMALZFIYAT', options);
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
      async Edit(CARMALZFIY_ID)
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
          const res = await fetch(config.API_LOCATION + 'CARIMALZFIYAT?ID=' + CARMALZFIY_ID, options);
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

          const res = await fetch(config.API_LOCATION + 'CARIMALZFIYAT', options);
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
          const res = await fetch(config.API_LOCATION + 'CARIMALZFIYAT', options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data.length > 0) {
            this.CARIMALZFIYATList = data;
           
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
      async Delete(CARMALZFIY_ID, index)
      {
        try {

          const options = {
            method: 'DELETE',
            headers: {'Content-Type': 'application/json',},
          };
          const res = await fetch(config.API_LOCATION + 'CARIMALZFIYAT?ID=' + CARMALZFIY_ID, options);
          if (!res.ok)
          {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == 'OK')
          {
            this.CARIMALZFIYATList.splice(index, 1)
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

