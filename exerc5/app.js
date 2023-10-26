'use strict';

const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

// Pergunta ao usuário
rl.question('Qual é o seu nome? ', (nome) => {
    console.log(`Olá, ${nome}!`);
    rl.close(); // Fecha a interface de leitura
});
debugger
