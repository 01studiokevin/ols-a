<template>
	<div id="menus">
		<el-row>
			<el-col :span="24">
				<div>
					<el-button type="primary" @click="dialogVisible = true">添加菜单</el-button>

					<el-dialog
						v-model="dialogVisible"
						title="添加菜单"
						width="30%"
						:before-close="handleClose"
					>
						<span>This is a message</span>
						<template #footer>
							<span class="dialog-footer">
								<el-button @click="dialogVisible = false">Cancel</el-button>
								<el-button type="primary" @click="dialogVisible = false">Confirm</el-button>
							</span>
						</template>
					</el-dialog>
				</div>
			</el-col>
		</el-row>

		<div class="mnues-content">
			<el-table
				:data="menus"
				style="width: 100%; margin-bottom: 20px"
				row-key="id"
				border
				default-expand-all
			>
				<el-table-column
					v-for="(item, index) in menus[0]"
					:key="item"
					:prop="index"
					:label="index"
					sortable
				/>
			</el-table>
		</div>
	</div>
</template>

<script>
import axios from "axios";
export default {
	data() {
		return {
			menus: [],
			dialogVisible: false,
		};
	},
	mounted() {
		var _this = this;
		axios.get("api/Manage/GetMenu").then(function (response) {
			_this.menus = response.data;
		});
	},
};
</script>

<style lang="scss" scoped>
.mnues-content {
	margin-top: 10px;
}
</style>
