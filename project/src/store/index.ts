import Vue from 'vue'
import Vuex from 'vuex'
import axios from 'axios'
import 'url-search-params-polyfill'


Vue.use(Vuex)

const params = new URLSearchParams()


const store = new Vuex.Store({
  state: {
      hatu:'asas'
  },
  getters: {
        
  },
  mutations: {
      increment(state,payload) {
        state.hatu = payload
      }
  },
  actions: {
      incrementActions(context, payload) {
          params.append('firstName', 'hello')
          axios.post('http://localhost:5000/WeatherForecast/post', params
        )
              .then(function (response) {
                  console.log(response.data["value"]);
        })
        .catch(function (error) {
            console.log(error);
        });
            context.commit('increment',payload)
      }
  },
  modules: {
  }
})

export default store
