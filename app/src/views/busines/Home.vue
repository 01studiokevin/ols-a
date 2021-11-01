<template>
	<div id="home-content">
		<div class="home-warp">
			<el-row :gutter="16">
				<el-col :span="6">
					<div class="home-left"></div>
				</el-col>
				<el-col :span="12"><div class="home-center"></div></el-col>
				<el-col :span="6"><div class="home-right"></div></el-col>
				<el-col :span="24" style="margin-top: 16px"><div class="home-bottom"></div></el-col>
			</el-row>
		</div>
	</div>
</template>

<script>
export default {};
</script>

<style lang="scss" scpode>
.home-left,
.home-right,
.home-center,
.home-bottom {
	background: #ffffff;
	border-radius: 5px;
	overflow: hidden;
}

.home-left,
.home-right,
.home-center {
	height: 500px;
}
.home-bottom {
	height: 50px;
}
</style>
