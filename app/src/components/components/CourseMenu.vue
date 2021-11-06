<template>
	<div id="CourseMenu">
		<div class="cm-slogan">{{ title }}</div>
		<el-row :gutter="16" v-for="group in courseList" :key="group">
			<el-col :span="24" class="cm-title">{{ group.title }}</el-col>
			<el-col :span="4" v-for="item in group.title.children" :key="item">
				<div class="cm-item">
					<router-link :to="'\/' + item.Action">{{ item.Name }}</router-link>
				</div>
			</el-col>
		</el-row>
	</div>
</template>

<script>
export default {
	name: "CourseMenu",
	data() {
		return {
			title: "好学兔，为您提供高质量教学课程",
		};
	},
	props: {
		courseList: {
			type: Array,
			default: null,
		},
	},
};
</script>

<style lang="scss" scoped>
.CourseMenu {
	width: 300px;
	padding: 10px 10px 10px 10px;
	box-shadow: 0px 0px 20px -11px rgba(0, 0, 0, 0.75);
}
</style>