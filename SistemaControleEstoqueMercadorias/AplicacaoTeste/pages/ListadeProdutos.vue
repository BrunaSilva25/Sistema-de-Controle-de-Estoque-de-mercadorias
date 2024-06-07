<template>
  <v-container>
    <h2>Lista de Produtos</h2>
    <ul>
      <li v-for="produto in produtos" :key="produto.id">
        {{ produto.Nome }} - {{ produto.Descricao }} - R$ {{ produto.Preco }}
      </li>
    </ul>
  </v-container>
</template>

<script>
export default {
  data() {
    return {
      produtos: []
    };
  },
  mounted() {
    this.carregarProdutos();
  },
  methods: {
    async carregarProdutos() {
      try {
        const response = await this.$axios.get("https://localhost:7248/Produto");
        this.produtos = response.data;
      } catch (error) {
        console.error("Erro ao carregar produtos:", error);
      }
    }
  }
};
</script>
