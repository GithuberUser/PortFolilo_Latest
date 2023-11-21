<template>
    <div class="requestbutton">
        <button type="button" @click="requestclick">アクセスボタン</button>
    </div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
@Component
export default class RequestButton extends Vue {
    public requestclick() {
        this.$emit('request')
    }
}</script>