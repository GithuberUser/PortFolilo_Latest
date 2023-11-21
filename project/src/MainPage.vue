<template>
    <div class="MainPage">
        <InputText @send="receive"/>
        <RequestButton @request="route"/>
        {{ message }}
        {{ houko }}
    </div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import InputText from './components/it/InputText.vue';
import RequestButton from './components/request/RequestButton.vue';

@Component({
    components: {
        InputText,
        RequestButton
    },
})
export default class MainPage extends Vue {
    message : string = '';
    houko : string = this.$store.state.hatu;
    receive(msg:string){
        this.message = msg;
    }
    route(){
        this.$store.dispatch('incrementActions',this.message)
        this.houko = this.$store.state.hatu
    }

    
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    h3 {
        margin: 40px 0 0;
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
