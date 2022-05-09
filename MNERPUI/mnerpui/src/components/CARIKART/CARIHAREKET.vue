<template>
  <div class='content-wrapper'>
    <div class='container-fluid'>
      <div class='col-12'>
        <div class='card mt-2'>
          <div class='card-header'>
            <div class='row'>
              <div class='col-5'>
                <button type='button' class='btn btn-info btn-sm' data-toggle='modal' data-target='#modal-xl' @click='Temizle()'>
                  <i class='fa fa-plus'></i> CARIHAREKET Ekle
                </button>
              </div>
              <div class='col-4'><h3 class=''><b>CARIHAREKET</b> </h3> </div>
              <div class='col-3'></div>
            </div>
          </div>
          <!-- /.card-header -->
          <div class='card-body'>

            <table id='example1' class='table table-bordered table-striped'>
              <thead>
                <tr><th>CARI_HAR_ID</th>
<th>CDATE</th>
<th>BORC</th>
<th>ALACAK</th>
<th>GIRISMI</th>
<th>CIKISMI</th>
<th>FTUR_ID</th>
<th>FIS_ID</th>
<th>TUTAR</th>
<th>DOV_ID</th>
<th>CEKSENNO</th>
<th>TAHNO</th>
<th>ISLEMTARIHI</th>
<th>CARI_ID</th>
<th>FISIDREF</th>
<th>FISIDREF2</th>
<th>FISIDREF3</th>
<th>ACIKLAMA</th>
<th>LDOV_ID</th>
<th>KUR1</th>
<th>KUR2</th>
<th>STOPAJORAN</th>
<th>STOPAJTUTAR</th>
<th>FONPAYIORAN</th>
<th>FONPAYITUTAR</th>
<th>BRKDVORAN</th>
<th>BRKDVTUTAR</th>
<th>NET</th>
<th>BRUT</th>
<th>KESTUTAR</th>
<th>TOPLAM</th>
<th>BNK_ID</th>
<th>TRANSACTION_ID</th>

                  <th></th>
                </tr>
              </thead>
              <tbody>
                <tr v-for='(n,index) in CARIHAREKETList'>
  <td>{{n.CARI_HAR_ID}}</td>
  <td>{{n.CDATE}}</td>
  <td>{{n.BORC}}</td>
  <td>{{n.ALACAK}}</td>
  <td>{{n.GIRISMI}}</td>
  <td>{{n.CIKISMI}}</td>
  <td>{{n.FTUR_ID}}</td>
  <td>{{n.FIS_ID}}</td>
  <td>{{n.TUTAR}}</td>
  <td>{{n.DOV_ID}}</td>
  <td>{{n.CEKSENNO}}</td>
  <td>{{n.TAHNO}}</td>
  <td>{{n.ISLEMTARIHI}}</td>
  <td>{{n.CARI_ID}}</td>
  <td>{{n.FISIDREF}}</td>
  <td>{{n.FISIDREF2}}</td>
  <td>{{n.FISIDREF3}}</td>
  <td>{{n.ACIKLAMA}}</td>
  <td>{{n.LDOV_ID}}</td>
  <td>{{n.KUR1}}</td>
  <td>{{n.KUR2}}</td>
  <td>{{n.STOPAJORAN}}</td>
  <td>{{n.STOPAJTUTAR}}</td>
  <td>{{n.FONPAYIORAN}}</td>
  <td>{{n.FONPAYITUTAR}}</td>
  <td>{{n.BRKDVORAN}}</td>
  <td>{{n.BRKDVTUTAR}}</td>
  <td>{{n.NET}}</td>
  <td>{{n.BRUT}}</td>
  <td>{{n.KESTUTAR}}</td>
  <td>{{n.TOPLAM}}</td>
  <td>{{n.BNK_ID}}</td>
  <td>{{n.TRANSACTION_ID}}</td>

                  <td>
                    <a class='btn btn-danger btn-sm sil text-white' @click='Delete(n.CARI_HAR_ID,index)'><i class='fas fa-trash'></i>Sil</a>
                    <a class='btn btn-info btn-sm edit text-white' data-toggle='modal' data-target='#modal-xl' @click='Edit(n.CARI_HAR_ID,index)'><i class='fas fa-edit'></i>Güncelle</a>
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
              <h4 class='modal-title'>CARIHAREKET</h4>
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
                      <h3 class='card-title'> {{ model.CARI_HAR_ID==null?'CARIHAREKET Ekle':'CARIHAREKET Düzenle' }}</h3>
                    </div>
                    <div class=''>
                      <div class='card-body'>
                      
                    

    <div class='form-group'>
                          <label for='CARI_HAR_ID'>CARI_HAR_ID</label>
                          <input type='text' v-model='model.CARI_HAR_ID' class='form-control' placeholder='CARI_HAR_ID'>
                        </div>
    <div class='form-group'>
                          <label for='CDATE'>CDATE</label>
                          <input type='text' v-model='model.CDATE' class='form-control' placeholder='CDATE'>
                        </div>
    <div class='form-group'>
                          <label for='BORC'>BORC</label>
                          <input type='text' v-model='model.BORC' class='form-control' placeholder='BORC'>
                        </div>
    <div class='form-group'>
                          <label for='ALACAK'>ALACAK</label>
                          <input type='text' v-model='model.ALACAK' class='form-control' placeholder='ALACAK'>
                        </div>
    <div class='form-group'>
                          <label for='GIRISMI'>GIRISMI</label>
                          <input type='text' v-model='model.GIRISMI' class='form-control' placeholder='GIRISMI'>
                        </div>
    <div class='form-group'>
                          <label for='CIKISMI'>CIKISMI</label>
                          <input type='text' v-model='model.CIKISMI' class='form-control' placeholder='CIKISMI'>
                        </div>
    <div class='form-group'>
                          <label for='FTUR_ID'>FTUR_ID</label>
                          <input type='text' v-model='model.FTUR_ID' class='form-control' placeholder='FTUR_ID'>
                        </div>
    <div class='form-group'>
                          <label for='FIS_ID'>FIS_ID</label>
                          <input type='text' v-model='model.FIS_ID' class='form-control' placeholder='FIS_ID'>
                        </div>
    <div class='form-group'>
                          <label for='TUTAR'>TUTAR</label>
                          <input type='text' v-model='model.TUTAR' class='form-control' placeholder='TUTAR'>
                        </div>
    <div class='form-group'>
                          <label for='DOV_ID'>DOV_ID</label>
                          <input type='text' v-model='model.DOV_ID' class='form-control' placeholder='DOV_ID'>
                        </div>
    <div class='form-group'>
                          <label for='CEKSENNO'>CEKSENNO</label>
                          <input type='text' v-model='model.CEKSENNO' class='form-control' placeholder='CEKSENNO'>
                        </div>
    <div class='form-group'>
                          <label for='TAHNO'>TAHNO</label>
                          <input type='text' v-model='model.TAHNO' class='form-control' placeholder='TAHNO'>
                        </div>
    <div class='form-group'>
                          <label for='ISLEMTARIHI'>ISLEMTARIHI</label>
                          <input type='text' v-model='model.ISLEMTARIHI' class='form-control' placeholder='ISLEMTARIHI'>
                        </div>
    <div class='form-group'>
                          <label for='CARI_ID'>CARI_ID</label>
                          <input type='text' v-model='model.CARI_ID' class='form-control' placeholder='CARI_ID'>
                        </div>
    <div class='form-group'>
                          <label for='FISIDREF'>FISIDREF</label>
                          <input type='text' v-model='model.FISIDREF' class='form-control' placeholder='FISIDREF'>
                        </div>
    <div class='form-group'>
                          <label for='FISIDREF2'>FISIDREF2</label>
                          <input type='text' v-model='model.FISIDREF2' class='form-control' placeholder='FISIDREF2'>
                        </div>
    <div class='form-group'>
                          <label for='FISIDREF3'>FISIDREF3</label>
                          <input type='text' v-model='model.FISIDREF3' class='form-control' placeholder='FISIDREF3'>
                        </div>
    <div class='form-group'>
                          <label for='ACIKLAMA'>ACIKLAMA</label>
                          <input type='text' v-model='model.ACIKLAMA' class='form-control' placeholder='ACIKLAMA'>
                        </div>
    <div class='form-group'>
                          <label for='LDOV_ID'>LDOV_ID</label>
                          <input type='text' v-model='model.LDOV_ID' class='form-control' placeholder='LDOV_ID'>
                        </div>
    <div class='form-group'>
                          <label for='KUR1'>KUR1</label>
                          <input type='text' v-model='model.KUR1' class='form-control' placeholder='KUR1'>
                        </div>
    <div class='form-group'>
                          <label for='KUR2'>KUR2</label>
                          <input type='text' v-model='model.KUR2' class='form-control' placeholder='KUR2'>
                        </div>
    <div class='form-group'>
                          <label for='STOPAJORAN'>STOPAJORAN</label>
                          <input type='text' v-model='model.STOPAJORAN' class='form-control' placeholder='STOPAJORAN'>
                        </div>
    <div class='form-group'>
                          <label for='STOPAJTUTAR'>STOPAJTUTAR</label>
                          <input type='text' v-model='model.STOPAJTUTAR' class='form-control' placeholder='STOPAJTUTAR'>
                        </div>
    <div class='form-group'>
                          <label for='FONPAYIORAN'>FONPAYIORAN</label>
                          <input type='text' v-model='model.FONPAYIORAN' class='form-control' placeholder='FONPAYIORAN'>
                        </div>
    <div class='form-group'>
                          <label for='FONPAYITUTAR'>FONPAYITUTAR</label>
                          <input type='text' v-model='model.FONPAYITUTAR' class='form-control' placeholder='FONPAYITUTAR'>
                        </div>
    <div class='form-group'>
                          <label for='BRKDVORAN'>BRKDVORAN</label>
                          <input type='text' v-model='model.BRKDVORAN' class='form-control' placeholder='BRKDVORAN'>
                        </div>
    <div class='form-group'>
                          <label for='BRKDVTUTAR'>BRKDVTUTAR</label>
                          <input type='text' v-model='model.BRKDVTUTAR' class='form-control' placeholder='BRKDVTUTAR'>
                        </div>
    <div class='form-group'>
                          <label for='NET'>NET</label>
                          <input type='text' v-model='model.NET' class='form-control' placeholder='NET'>
                        </div>
    <div class='form-group'>
                          <label for='BRUT'>BRUT</label>
                          <input type='text' v-model='model.BRUT' class='form-control' placeholder='BRUT'>
                        </div>
    <div class='form-group'>
                          <label for='KESTUTAR'>KESTUTAR</label>
                          <input type='text' v-model='model.KESTUTAR' class='form-control' placeholder='KESTUTAR'>
                        </div>
    <div class='form-group'>
                          <label for='TOPLAM'>TOPLAM</label>
                          <input type='text' v-model='model.TOPLAM' class='form-control' placeholder='TOPLAM'>
                        </div>
    <div class='form-group'>
                          <label for='BNK_ID'>BNK_ID</label>
                          <input type='text' v-model='model.BNK_ID' class='form-control' placeholder='BNK_ID'>
                        </div>
    <div class='form-group'>
                          <label for='TRANSACTION_ID'>TRANSACTION_ID</label>
                          <input type='text' v-model='model.TRANSACTION_ID' class='form-control' placeholder='TRANSACTION_ID'>
                        </div>


                        
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class='modal-footer justify-content-between'>
              <button type='button' class='btn btn-danger' data-dismiss='modal'>Kapat</button>
              <button type='button' class='btn btn-info' v-on:click='(model.CARI_HAR_ID==null?Save():Update())'>Kaydet</button>
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

    name: 'CARIHAREKET',
    data() {
      return {
        model: {
CARI_HAR_ID:null,
       CDATE:'',
BORC:'',
ALACAK:'',
GIRISMI:'',
CIKISMI:'',
FTUR_ID:'',
FIS_ID:'',
TUTAR:'',
DOV_ID:'',
CEKSENNO:'',
TAHNO:'',
ISLEMTARIHI:'',
CARI_ID:'',
FISIDREF:'',
FISIDREF2:'',
FISIDREF3:'',
ACIKLAMA:'',
LDOV_ID:'',
KUR1:'',
KUR2:'',
STOPAJORAN:'',
STOPAJTUTAR:'',
FONPAYIORAN:'',
FONPAYITUTAR:'',
BRKDVORAN:'',
BRKDVTUTAR:'',
NET:'',
BRUT:'',
KESTUTAR:'',
TOPLAM:'',
BNK_ID:'',
TRANSACTION_ID:'',

        },
        CARIHAREKETList: [],
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
       
          const res = await fetch(config.API_LOCATION + 'CARIHAREKET', options);
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
      async Edit(CARI_HAR_ID)
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
          const res = await fetch(config.API_LOCATION + 'CARIHAREKET?ID=' + CARI_HAR_ID, options);
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

          const res = await fetch(config.API_LOCATION + 'CARIHAREKET', options);
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
          const res = await fetch(config.API_LOCATION + 'CARIHAREKET', options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data.length > 0) {
            this.CARIHAREKETList = data;
           
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
      async Delete(CARI_HAR_ID, index)
      {
        try {

          const options = {
            method: 'DELETE',
            headers: {'Content-Type': 'application/json',},
          };
          const res = await fetch(config.API_LOCATION + 'CARIHAREKET?ID=' + CARI_HAR_ID, options);
          if (!res.ok)
          {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == 'OK')
          {
            this.CARIHAREKETList.splice(index, 1)
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

