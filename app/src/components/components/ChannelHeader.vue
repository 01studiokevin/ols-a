<template>
	<div id="channel">
		<div class="channel-header">
			<el-container>
				<el-header></el-header>
			</el-container>
		</div>
		<div class="channel-content">
			<router-view></router-view>
		</div>
	</div>
</template>

<script>
export default {
	data() {
		return {};
	},
	props: {},
	mounted: {},
};
</script>

<style lang="scss" scoped></style>
