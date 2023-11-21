<template>
    <div class="buttonin">
        <button type="button" @click="click">ボタン</button>
    </div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
@Component
export default class ButtonIn extends Vue {
    public click() {
        this.$emit('parent-event')
    }
}</script>