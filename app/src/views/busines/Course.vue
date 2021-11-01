<template>
	<a-row style="height: 100px; border: 1px solid red" type="flex" justify="space-around" align="middle">
		<a-col :span="4">
			<div class="height-10"><a-input-search v-model:value="value" placeholder="input search text" enter-button /></div>
		</a-col>
		<a-col :span="4">
			<div class="height-10"><a-input-search v-model:value="value" placeholder="input search text" enter-button /></div>
		</a-col>
		<a-col :span="4">
			<div class="height-10"><a-input-search v-model:value="value" placeholder="input search text" enter-button /></div>
		</a-col>
		<a-col :span="4">
			<div class="height-10"><a-input-search v-model:value="value" placeholder="input search text" enter-button /></div>
		</a-col>
	</a-row>
</template>

<style lang="scss" scoped>
.height-10 {
	border: 1px solid red;
}
</style>
