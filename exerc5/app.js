'use strict';

const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

// Pergunta ao usu�rio
rl.question('Qual � o seu nome? ', (nome) => {
    console.log(`Ol�, ${nome}!`);
    rl.close(); // Fecha a interface de leitura
});
debugger
