<template>
  <v-container>
    <h2>Lista de Categorias</h2>
    <ul>
      <li v-for="categoria in categorias" :key="categoria.id">
        {{ categoria.Nome }} - {{ categoria.Descricao }}
      </li>
    </ul>
  </v-container>
</template>

<script>
export default {
  data() {
    return {
      categorias: []
    };
  },
  mounted() {
    this.carregarCategorias();
  },
  methods: {
    async carregarCategorias() {
      try {
        const response = await this.$axios.get("https://localhost:7248/Categoria");
        this.categorias = response.data;
      } catch (error) {
        console.error("Erro ao carregar categorias:", error);
      }
    }
  }
};
</script>
