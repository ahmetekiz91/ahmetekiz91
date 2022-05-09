import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/components/Home'
import Users from '@/components/Users'
import Attributes from '@/components/Malzeme/Attributes'
import AttributesValue from '@/components/Malzeme/AttributesValue'
import CARIGRUPLAR from '@/components/CARIKART/CARIGRUPLAR';
import CARIKART from '@/components/CARIKART/CARIKART';
import Plasiyerler from '@/components/CARIKART/Plasiyerler';
import 'vuejs-dialog/dist/vuejs-dialog.min.css';
import VuejsDialog from 'vuejs-dialog';

Vue.use(VuejsDialog);
// import p1 from '../../plugins/jquery/jquery.min.js';
// Vue.use(p1);
window.$ = window.jQuery = require('../../plugins/jquery/jquery.min.js');


require('../../plugins/jquery-ui/jquery-ui.min.js');
require('../../plugins/chartjs/Chart.min.js');
require('../../plugins/bootstrap/js/bootstrap.bundle.min.js');
require('../../dist/js/adminlte.min.js');


Vue.use(Router);
export default new Router({
  routes: [
    {
      path: '/',
      name: 'Home',
      component: Home
    },
    {
      path: '/users',
      name: 'Users',
      component: Users
    },
    {
      path: '/attributes',
      name: 'Attributes',
      component: Attributes
    },
    {
      path: '/attributesvalue',
      name: 'AttributesValue',
      component: AttributesValue
    },
    {
      path: '/carigruplar',
      name: 'CARIGRUPLAR',
      component: CARIGRUPLAR
    },
    {
      path: '/carikart',
      name: 'CARIKART',
      component: CARIKART
    },
    {
      path: '/plasiyerler',
      name: 'Plasiyerler',
      component: Plasiyerler
    }
  ]
})
