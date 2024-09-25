namespace abacate;

public class Questao
{
    public string Pergunta;
    public string Resposta1;
    public string Resposta2;
    public string Resposta3;

    public string Resposta4;

    public string Resposta5;

    public string Resposta6;

    public int nivelpergunta;
    public int respostaCorreta;
    public int estruturadesenho;
    public int pontuação;
    Label labelPergunta;
    Button buttonResposta1;
    Button buttonResposta2;
    Button buttonResposta3;
    Button buttonResposta4;
    Button buttonResposta5;
    Button buttonResposta6;

    public void ConfiguraDesenho(Label labelPergunta, Button buttonResposta1, Button buttonResposta2, Button buttonResposta3, Button buttonResposta4, Button buttonResposta5)
    {
        this.labelPergunta = labelPergunta;
        this.buttonResposta1 = buttonResposta1;
        this.buttonResposta2 = buttonResposta2;
        this.buttonResposta3 = buttonResposta3;
        this.buttonResposta4 = buttonResposta4;
        this.buttonResposta5 = buttonResposta5;
    }

    public void Desenhar()
    {
        labelPergunta.Text = Pergunta;
        buttonResposta1.Text = Resposta2;
        buttonResposta3.Text = TexResposta3;
        buttonResposta4.Text = Resposta4;
        buttonResposta5.Text = Resposta5;

        this buttonRespost
        a1!BackgroundColor =
        Colors.Brown;
        thisbuttonRespost
        a2!BackgroundColor =
        Colors.Brown;
        this.buttonRespost
        a3!BackgroundColor =
        Colors.Brown;
        this.buttonRespost
        a4!BackgroundColor
        Colors.Brown;
        thisbuttonRespost
        a5!BackgroundColor =
        Colors.Brown;
    }
}
