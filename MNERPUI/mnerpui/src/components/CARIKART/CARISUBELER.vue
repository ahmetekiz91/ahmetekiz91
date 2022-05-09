<template>
  <div class='content-wrapper'>
    <div class='container-fluid'>
      <div class='col-12'>
        <div class='card mt-2'>
          <div class='card-header'>
            <div class='row'>
              <div class='col-5'>
                <button type='button' class='btn btn-info btn-sm' data-toggle='modal' data-target='#modal-xl' @click='Temizle()'>
                  <i class='fa fa-plus'></i> CARISUBELER Ekle
                </button>
              </div>
              <div class='col-4'><h3 class=''><b>CARISUBELER</b> </h3> </div>
              <div class='col-3'></div>
            </div>
          </div>
          /.card-header
          <div class='card-body'>

            <table id='example1' class='table table-bordered table-striped'>
              <thead>
                <tr>
                  <th>CARI_ADR_ID</th>
                  <th>CDATE</th>
                  <th>KODU</th>
                  <th>ADI</th>
                  <th>CARI_REF_NO</th>
                  <th>ADRES</th>
                  <th>SEHIR</th>
                  <th>ILCE</th>
                  <th>IL</th>
                  <th>POSTAKODU</th>
                  <th>CUSR_ID</th>
                  <th>UUSR_ID</th>
                  <th>UDATE</th>
                  <th>ENLEM</th>
                  <th>BOYLAM</th>

                  <th></th>
                </tr>
              </thead>
              <tbody>
                <tr v-for='(n,index) in CARISUBELERList'>
                  <td>{{n.CARI_ADR_ID}}</td>
                  <td>{{n.CDATE}}</td>
                  <td>{{n.KODU}}</td>
                  <td>{{n.ADI}}</td>
                  <td>{{n.CARI_REF_NO}}</td>
                  <td>{{n.ADRES}}</td>
                  <td>{{n.SEHIR}}</td>
                  <td>{{n.ILCE}}</td>
                  <td>{{n.IL}}</td>
                  <td>{{n.POSTAKODU}}</td>
                  <td>{{n.CUSR_ID}}</td>
                  <td>{{n.UUSR_ID}}</td>
                  <td>{{n.UDATE}}</td>
                  <td>{{n.ENLEM}}</td>
                  <td>{{n.BOYLAM}}</td>

                  <td>
                    <a class='btn btn-danger btn-sm sil text-white' @click='Delete(n.CARI_ADR_ID,index)'><i class='fas fa-trash'></i>Sil</a>
                    <a class='btn btn-info btn-sm edit text-white' data-toggle='modal' data-target='#modal-xl' @click='Edit(n.CARI_ADR_ID,index)'><i class='fas fa-edit'></i>Güncelle</a>
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
              <h4 class='modal-title'>CARISUBELER</h4>
              <button type='button' class='close' data-dismiss='modal' aria-label='Close'>
                <span aria-hidden='true'>&times;</span>
              </button>
            </div>
            <div class='modal-body'>
              <div class='row'>
                left column
                <div class='col-md-12'>
                  general form elements
                  <div class='card card-info'>
                    <div class='card-header'>
                      <h3 class='card-title'> {{ model.CARI_ADR_ID==null?'CARISUBELER Ekle':'CARISUBELER Düzenle' }}</h3>
                    </div>
                    <div class=''>
                      <div class='card-body'>



                        <div class='form-group'>
                          <label for='CARI_ADR_ID'>CARI_ADR_ID</label>
                          <input type='text' v-model='model.CARI_ADR_ID' class='form-control' placeholder='CARI_ADR_ID'>
                        </div>
                        <div class='form-group'>
                          <label for='CDATE'>CDATE</label>
                          <input type='text' v-model='model.CDATE' class='form-control' placeholder='CDATE'>
                        </div>
                        <div class='form-group'>
                          <label for='KODU'>KODU</label>
                          <input type='text' v-model='model.KODU' class='form-control' placeholder='KODU'>
                        </div>
                        <div class='form-group'>
                          <label for='ADI'>ADI</label>
                          <input type='text' v-model='model.ADI' class='form-control' placeholder='ADI'>
                        </div>
                        <div class='form-group'>
                          <label for='CARI_REF_NO'>CARI_REF_NO</label>
                          <input type='text' v-model='model.CARI_REF_NO' class='form-control' placeholder='CARI_REF_NO'>
                        </div>
                        <div class='form-group'>
                          <label for='ADRES'>ADRES</label>
                          <input type='text' v-model='model.ADRES' class='form-control' placeholder='ADRES'>
                        </div>
                        <div class='form-group'>
                          <label for='SEHIR'>SEHIR</label>
                          <input type='text' v-model='model.SEHIR' class='form-control' placeholder='SEHIR'>
                        </div>
                        <div class='form-group'>
                          <label for='ILCE'>ILCE</label>
                          <input type='text' v-model='model.ILCE' class='form-control' placeholder='ILCE'>
                        </div>
                        <div class='form-group'>
                          <label for='IL'>IL</label>
                          <input type='text' v-model='model.IL' class='form-control' placeholder='IL'>
                        </div>
                        <div class='form-group'>
                          <label for='POSTAKODU'>POSTAKODU</label>
                          <input type='text' v-model='model.POSTAKODU' class='form-control' placeholder='POSTAKODU'>
                        </div>
                        <div class='form-group'>
                          <label for='CUSR_ID'>CUSR_ID</label>
                          <input type='text' v-model='model.CUSR_ID' class='form-control' placeholder='CUSR_ID'>
                        </div>
                        <div class='form-group'>
                          <label for='UUSR_ID'>UUSR_ID</label>
                          <input type='text' v-model='model.UUSR_ID' class='form-control' placeholder='UUSR_ID'>
                        </div>
                        <div class='form-group'>
                          <label for='UDATE'>UDATE</label>
                          <input type='text' v-model='model.UDATE' class='form-control' placeholder='UDATE'>
                        </div>
                        <div class='form-group'>
                          <label for='ENLEM'>ENLEM</label>
                          <input type='text' v-model='model.ENLEM' class='form-control' placeholder='ENLEM'>
                        </div>
                        <div class='form-group'>
                          <label for='BOYLAM'>BOYLAM</label>
                          <input type='text' v-model='model.BOYLAM' class='form-control' placeholder='BOYLAM'>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class='modal-footer justify-content-between'>
              <button type='button' class='btn btn-danger' data-dismiss='modal'>Kapat</button>
              <button type='button' class='btn btn-info' v-on:click='(model.CARI_ADR_ID==null?Save():Update())'>Kaydet</button>
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

    name: 'CARISUBELER',
    data() {
      return {
        model: {
          CARI_ADR_ID: null,
          CDATE: '',
          KODU: '',
          ADI: '',
          CARI_REF_NO: '',
          ADRES: '',
          SEHIR: '',
          ILCE: '',
          IL: '',
          POSTAKODU: '',
          CUSR_ID: '',
          UUSR_ID: '',
          UDATE: '',
          ENLEM: '',
          BOYLAM: '',

        },
        CARISUBELERList: [],
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

          const res = await fetch(config.API_LOCATION + 'CARISUBELER', options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == 'OK') {
            this.List();
            alert('Eklendi');
          }

        } catch (err) {
          console.log(err.message);
        }
      },
      async Edit(CARI_ADR_ID) {
        const options =
        {
          method: 'PUT',
          headers: {
            'Content-Type': 'application/json',
          },
        };
        try {
          const res = await fetch(config.API_LOCATION + 'CARISUBELER?ID=' + CARI_ADR_ID, options);
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

          const res = await fetch(config.API_LOCATION + 'CARISUBELER', options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == 'OK') {
            this.List();
            alert('bilgiler güncellendi');
            return;
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
          const res = await fetch(config.API_LOCATION + 'CARISUBELER', options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data.length > 0) {
            this.CARISUBELERList = data;

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
        } catch (err) {
          console.log(err.message);
        }
      },
      async Delete(CARI_ADR_ID, index) {
        try {

          const options = {
            method: 'DELETE',
            headers: { 'Content-Type': 'application/json', },
          };
          const res = await fetch(config.API_LOCATION + 'CARISUBELER?ID=' + CARI_ADR_ID, options);
          if (!res.ok) {
            const message = 'An error has occured: ${res.status} - ${res.statusText}';
            throw new Error(message);
          }
          const data = await res.json();
          if (data == 'OK') {
            this.CARISUBELERList.splice(index, 1)
            alert('Kayıt silindi');
          }
          else {
            alert('Hata Oluştu');
          }
        } catch (err) {
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

