<template>
  <v-container>
    <h2>Cadastro de Categoria</h2>
    <v-form @submit.prevent="submit">
      <v-text-field v-model="categoria.Nome" label="Nome" required></v-text-field>
      <v-text-field v-model="categoria.Descricao" label="Descrição"></v-text-field>
      <v-btn type="submit" color="primary">Salvar Categoria</v-btn>
    </v-form>
  </v-container>
</template>

<script>
export default {
  data() {
    return {
      categoria: {
        Nome: "",
        Descricao: ""
      }
    };
  },
  methods: {
    async submit() {
      try {
        await this.$axios.post("https://localhost:7248/Categoria", this.categoria);
        this.$router.push("/categorias");
      } catch (error) {
        console.error("Erro ao criar categoria:", error);
      }
    }
  }
};
</script>
