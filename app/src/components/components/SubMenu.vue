<template>
	<template v-for="item in subMenuList">
		<el-submenu v-if="item.SubMenu && item.SubMenu.length > 0" :key="item" :index="item.Path">
			<span>
				<router-link :to="'\/' + item.Action">{{ item.Name }}</router-link>
			</span>
			<template v-slot:title></template>
			<SubMenu :subMenuList="item.SubMenu" />
		</el-submenu>
		<el-menu-item v-else :key="item.path" :index="item.path">
			<span>
				<router-link :to="'\/' + item.Action">{{ item.Name }}</router-link>
			</span>
		</el-menu-item>
	</template>
</template>

<script>
import SubMenu from "./SubMenu";

export default {
	name: "SubMenu", //必须要 递归组件的关键，并且要与引入组件的变量名称一致
	components: {
		SubMenu,
	},
	props: {
		subMenuList: {
			//接收到的菜单信息
			type: Array,
			default: null,
		},
		// authority: {
		// 	//填报权限 0 1不展示
		// 	type: Number,
		// 	default: 0,
		// },
		// mode: {
		// 	//菜单 水平  垂直
		// 	type: String,
		// 	default: "horizontal",
		// },
	},
	data() {
		return {};
	},
	computed: {},
	//生命周期 - 创建完成
	created() {},
	//DOM挂载完毕
	mounted() {},
	methods: {},
};
</script>
<style lang="scss" scoped></style>
