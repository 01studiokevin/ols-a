<template>
  <div id="test">
    <div v-for="item in tabs" :key="item.text">
      <div
        class="tab"
        :class="{ active: item.isActive }"
        @click="changeTab(item)"
      >
        {{ item.text }}
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      tabs: [
        { text: "login", isActive: true },
        { text: "regsiter", isActive: false },
      ],
    };
  },
  methods: {
    changeTab(data) {
      this.tabs.forEach((ele) => {
        ele.isActive = false;
      });
      data.isActive = true;
    },
  },
};
</script>



<style lang="scss" scoped>
.tab {
  padding: 1rem 2rem;
}
.active {
  position: relative;
}
.active::after {
  content: "";
  display: block;
  position: absolute;
  height: 3px;
  bottom: 0;
  width: 100%;
  background-color: red;
}
</style>