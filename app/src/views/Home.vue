<template>
  <div id="home-content">
    <div class="home-warp">
      <a-row :gutter="[16, 16]">
        <a-col :span="6">
          <div class="home-left"></div>
        </a-col>
        <a-col :span="12"><div class="home-center"></div></a-col>
        <a-col :span="6"><div class="home-right"></div></a-col>
        <a-col :span="24"><div class="home-bottom"></div></a-col>
      </a-row>
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
