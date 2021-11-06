<template>
	<el-container style="height: 500px; border: 1px solid #eee">
		<el-aside class="m-aside" width="200px" style="background-color: rgb(238, 241, 246)">
			<el-menu default-active="1">
				<sub-menu :subMenuList="menu"></sub-menu>
			</el-menu>
		</el-aside>
		<el-container>
			<el-header style="text-align: right; font-size: 12px">
				<el-dropdown>
					<el-icon style="margin-right: 15px"><setting /></el-icon>
					<template #dropdown>
						<el-dropdown-menu>
							<el-dropdown-item>View</el-dropdown-item>
							<el-dropdown-item>Add</el-dropdown-item>
							<el-dropdown-item>Delete</el-dropdown-item>
						</el-dropdown-menu>
					</template>
				</el-dropdown>
				<span>Tom</span>
			</el-header>

			<el-main>
				<router-view></router-view>
			</el-main>
		</el-container>
	</el-container>
</template>

<script>
import axios from "axios";
import { Setting } from "@element-plus/icons";
import { SubMenu } from "../../components/index";
export default {
	name: "AdminLayout",
	data() {
		return {
			menu: null,
		};
	},
	components: {
		Setting,
		SubMenu,
	},
	methods: {},
	mounted() {
		var _this = this;
		axios.get("api/Manage/GetMenu").then(function (response) {
			_this.menu = response.data;
		});
	},
};
</script>

<style lang="scss" scoped>
.el-header {
	background-color: #b3c0d1;
	color: var(--el-text-color-primary);
	line-height: 60px;
}

.el-aside {
	color: var(--el-text-color-primary);
	overflow-x: hidden;
	overflow-y: scroll;
	&::-webkit-scrollbar {
		width: 0;
	}
}
</style>
