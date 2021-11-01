<template>
	<div id="channel">
		<div class="channel-header">
			<el-container :style="{ position: 'fiexd' }">
				<el-header></el-header>
			</el-container>
		</div>
		<div class="channel-content">
			<router-view></router-view>
		</div>
	</div>
</template>

<script>
// import axios from "axios";
export default {
	data() {
		return {
			headerPosition: "block",
			navs: null,
		};
	},
	mounted: {
		// 	initdata() {
		// 		axios({
		// 			method: "get",
		// 			url: "",
		// 			data: {
		// 				firstName: "Fred",
		// 				lastName: "Flintstone",
		// 			},
		// 		});
		// 	},
	},
};
</script>

<style lang="scss" scoped></style>
