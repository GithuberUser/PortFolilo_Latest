<template>
    <div class="InputText">
        <input type="text" v-model="submit" />
        <ButtonIn @parent-event="parentEvent"/>
    </div>
</template>

<script lang="ts">
import ButtonIn from './bi/ButtonIn.vue'
import { Component, Emit, Vue } from 'vue-property-decorator';
@Component({
    components: {
        ButtonIn,
    },
})
export default class InputText extends Vue {
    submit: string = ''
    obj: string = ''
    public parentEvent(): void {
        this.obj = this.submit;
        this.$emit('send', this.obj)
    }
}
</script>