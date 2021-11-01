<template>
	<div id="login">
		<div class="login-wrap">
			<a-row :gutter="16">
				<a-col :span="12" class="login-bg">
					<div class="login-content">
						<img src="../../assets/bg1.svg" alt="logo" width="100%" height="100%" />
					</div>
				</a-col>
				<a-col :span="12" class="form-content">
					<div class="form-warp">
						<a-row>
							<a-col v-for="item in tabs" :key="item.text" :class="{ active: item.isActive }">
								<div class="tab" @click="changeTab(item)">{{ item.text }}</div>
							</a-col>
						</a-row>
						<a-form :model="formState" :rules="rules" v-bind="layout" layout="vertical" class="form">
							<a-form-item has-feedback label="账户" name="account">
								<a-input v-model:value="formState.account" type="text" autocomplete="off" />
							</a-form-item>
							<a-form-item has-feedback label="密码" name="pwd">
								<a-input v-model:value="formState.pwd" type="password" autocomplete="off" />
							</a-form-item>
							<a-form-item :wrapper-col="{ span: 14, offset: 4 }">
								<a-button type="primary" html-type="submit" @click="login()">登录</a-button>
							</a-form-item>
						</a-form>
						<a-row class="tips">
							<a-col :span="12" class="text-left">
								<a href="">用户隐私策略</a>
							</a-col>
							<a-col :span="12" class="text-right">
								<a href="">忘记密码？</a>
							</a-col>
						</a-row>
					</div>
				</a-col>
			</a-row>
		</div>
	</div>
</template>

<script>
import axios from "axios";
export default {
	data() {
		return {
			formState: {
				account: "",
				pwd: "",
			},
			rules: {
				account: [
					{
						required: true,
						message: "请输入账户！",
						trigger: "change",
					},
				],
				pwd: [
					{
						required: true,
						message: "请输入密码！",
						trigger: "change",
					},
				],
			},
			tabs: [
				{ text: "登录", isActive: true },
				{ text: "注册", isActive: false },
			],
		};
	},
	methods: {
		changeTab(item) {
			this.tabs.forEach((ele) => {
				ele.isActive = false;
			});
			item.isActive = true;
		},
		login() {
			axios
				.get("/Login", {
					params: {
						account: this.formState.account,
						pwd: this.formState.pwd,
					},
				})
				.then(function (response) {
					alert(response.data);
				})
				.catch(function (error) {
					alert(error);
				})
				.then(function () {
					// 总是会执行
				});
		},
	},
};
</script>

<style lang="scss" scoped>
#login {
	width: 100%;
	height: 100vh;
	// background: #2980b9;
	display: flex;
	justify-content: center;
	align-items: center;
}
.login-wrap {
	background: white;
	padding: 5rem 5rem 5rem 5rem;
	width: 70%;
	border-radius: 1rem;
	box-shadow: 0px 8px 17px 2px rgba(0, 0, 0, 0.14), 0px 3px 14px 2px rgba(0, 0, 0, 0.12), 0px 5px 5px -3px rgba(0, 0, 0, 0.2);
	overflow: hidden;
}
.login-bg div,
img {
	width: 100%;
	height: 100%;
}

.form-content {
	display: flex;
	justify-content: center;
	align-items: center;
}

.tab {
	padding: 1rem 2rem 1rem 2rem;
	margin-left: 1rem;
}
.active {
	position: relative;
}
.active::after {
	display: block;
	position: absolute;
	bottom: 0;
	content: "";
	width: 100%;
	height: 3px;
	background-color: #2980b9;
}

.form {
	margin-top: 2rem;
}

.text-right {
	text-align: right;
}

.text-left {
	text-align: left;
}
</style>
