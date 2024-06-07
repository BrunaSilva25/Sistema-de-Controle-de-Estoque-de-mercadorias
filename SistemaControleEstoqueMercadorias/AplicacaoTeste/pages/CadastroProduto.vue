<template>
  <v-container>
    <v-form @submit.prevent="submit">
      <v-text-field v-model="produto.Nome" label="Nome" required></v-text-field>
      <v-text-field v-model="produto.Descricao" label="Descrição"></v-text-field>
      <v-text-field v-model="produto.Preco" label="Preço" required type="number"></v-text-field>
      <v-text-field v-model="produto.QuantidadeEmEstoque" label="Quantidade em Estoque" required type="number"></v-text-field>
      <v-text-field v-model="produto.CategoriaID" label="ID da Categoria" required type="number"></v-text-field>
      <v-btn type="submit" color="primary">Salvar Produto</v-btn>
    </v-form>
  </v-container>
</template>

<script>
export default {
  data() {
    return {
      produto: {
        Nome: "",
        Descricao: "",
        Preco: 0,
        QuantidadeEmEstoque: 0,
        CategoriaID: 0
      }
    };
  },
  methods: {
    async submit() {
      try {
        await this.$axios.post("https://localhost:7248/Produto", this.produto);
        this.$router.push("/produtos");
      } catch (error) {
        console.error("Erro ao criar produto:", error);
      }
    }
  }
};
</script>
