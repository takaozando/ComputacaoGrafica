using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GLDraw : MonoBehaviour
{
    public Material material;
    
    private void OnPostRender()
    {
		 GL.PushMatrix();
		 material.SetPass(0);
         GL.Begin(GL.LINES);

        GeraQuadrado(5);
        GeraTrianguloEquilatero(5);
        GeraHexagono(5);
        GeraAlmaco(5);

        GeraX(5);
        GeraSetaDireita();
        GeraCantoEsquerdo();
        GeraEstrela();
        GeraCaixaComSetasLaterais();
        GeraQuadradoComNum7();
        GeraHexagonoComNum4();
        GeraEstrelaComNum1();
        GeraPisoQuadrado();
        GeraCubo();
        GeraDesenhoCasa();
        
        GL.End();
        GL.PopMatrix();
	}

    private void GeraDesenhoCasa()
    {
        GeraQuadrado(5);
        GL.Vertex(new Vector3(3.5f, 3.5f));
        GL.Vertex(new Vector3(3.5f, 4));
        GL.Vertex(new Vector3(3.5f, 4));
        GL.Vertex(new Vector3(3.8f, 4));
        GL.Vertex(new Vector3(3.8f, 4));
        GL.Vertex(new Vector3(3.8f, 3.4f));
        GL.Vertex(new Vector3(4.5f, 3));
        GL.Vertex(new Vector3(2.5f, 4));
        GL.Vertex(new Vector3(2.5f, 4));
        GL.Vertex(new Vector3(0.5f, 3));
        GL.Vertex(new Vector3(0.5f, 3));
        GL.Vertex(new Vector3(4.5f, 3));
        GL.Vertex(new Vector3(1, 1));
        GL.Vertex(new Vector3(4, 1));
        GL.Vertex(new Vector3(4, 1));
        GL.Vertex(new Vector3(4, 3));
        GL.Vertex(new Vector3(1, 3));
        GL.Vertex(new Vector3(1, 1));
        GL.Vertex(new Vector3(2.3f, 1));
        GL.Vertex(new Vector3(2.3f, 2));
        GL.Vertex(new Vector3(2.3f, 2));
        GL.Vertex(new Vector3(2.6f, 2));
        GL.Vertex(new Vector3(2.6f, 2));
        GL.Vertex(new Vector3(2.6f, 1));
    }

    private void GeraCubo()
    {
        GeraQuadrado(5);
        GL.Vertex(new Vector3(5, 0));
        GL.Vertex(new Vector3(6, 1));
        GL.Vertex(new Vector3(6, 1));
        GL.Vertex(new Vector3(6, 6));
        GL.Vertex(new Vector3(6, 6));
        GL.Vertex(new Vector3(5, 5));
        GL.Vertex(new Vector3(1, 6));
        GL.Vertex(new Vector3(0, 5));
        GL.Vertex(new Vector3(1, 6));
        GL.Vertex(new Vector3(6, 6));
    }

    private void GeraPisoQuadrado()
    {
        GL.Vertex(new Vector3(0, 0));
        GL.Vertex(new Vector3(5, 0));
        GL.Vertex(new Vector3(5, 0));
        GL.Vertex(new Vector3(5, 5));
        GL.Vertex(new Vector3(5, 5));
        GL.Vertex(new Vector3(0, 5));
        GL.Vertex(new Vector3(0, 0));
        GL.Vertex(new Vector3(0, 5));
        GL.Vertex(new Vector3(1, 1));
        GL.Vertex(new Vector3(4, 1));
        GL.Vertex(new Vector3(4, 1));
        GL.Vertex(new Vector3(4, 4));
        GL.Vertex(new Vector3(4, 4));
        GL.Vertex(new Vector3(1, 4));
        GL.Vertex(new Vector3(1, 1));
        GL.Vertex(new Vector3(1, 4));
        GL.Vertex(new Vector3(0, 0));
        GL.Vertex(new Vector3(1, 1));
        GL.Vertex(new Vector3(0, 5));
        GL.Vertex(new Vector3(1, 4));
        GL.Vertex(new Vector3(5, 5));
        GL.Vertex(new Vector3(4, 4));
        GL.Vertex(new Vector3(5, 0));
        GL.Vertex(new Vector3(4, 1));
    }
    private void GeraEstrelaComNum1()
    {
        GeraEstrela();
        GL.Vertex(new Vector3(2.5f, 2));
        GL.Vertex(new Vector3(2.5f, 4));
        GL.Vertex(new Vector3(2.5f, 4));
        GL.Vertex(new Vector3(2, 3.5f));

    }

    private void GeraHexagonoComNum4()
    {
        GeraHexagono(5);
        GL.Vertex(new Vector3(3, 1.5f));
        GL.Vertex(new Vector3(3, 3.5f));
        GL.Vertex(new Vector3(3, 3.5f));
        GL.Vertex(new Vector3(2, 2));
        GL.Vertex(new Vector3(2, 2));
        GL.Vertex(new Vector3(3.2f, 2));
    }

    private void GeraQuadradoComNum7()
    {
        GL.Vertex(new Vector3(0, 0));
        GL.Vertex(new Vector3(5, 0));
        GL.Vertex(new Vector3(5, 0));
        GL.Vertex(new Vector3(5, 5));
        GL.Vertex(new Vector3(5, 5));
        GL.Vertex(new Vector3(0, 5));
        GL.Vertex(new Vector3(0, 0));
        GL.Vertex(new Vector3(0, 5));
        GL.Vertex(new Vector3(2.5f, 1.5f));
        GL.Vertex(new Vector3(3, 3));
        GL.Vertex(new Vector3(3, 3));
        GL.Vertex(new Vector3(2, 3));
    }

    private void GeraCaixaComSetasLaterais()
    {
        GL.Vertex(new Vector3(0, 2.5f));
        GL.Vertex(new Vector3(1, 2));
        GL.Vertex(new Vector3(1, 2));
        GL.Vertex(new Vector3(1, 2.2f));
        GL.Vertex(new Vector3(1, 2.2f));
        GL.Vertex(new Vector3(3, 2.2f));
        GL.Vertex(new Vector3(3, 2.2f));
        GL.Vertex(new Vector3(3, 1));
        GL.Vertex(new Vector3(3, 1));
        GL.Vertex(new Vector3(6, 1));
        GL.Vertex(new Vector3(6, 1));
        GL.Vertex(new Vector3(6, 2.2f));
        GL.Vertex(new Vector3(6, 2.2f));
        GL.Vertex(new Vector3(8, 2.2f));
        GL.Vertex(new Vector3(8, 2.2f));
        GL.Vertex(new Vector3(8, 2));
        GL.Vertex(new Vector3(8, 2));
        GL.Vertex(new Vector3(9, 2.5f));
        GL.Vertex(new Vector3(9, 2.5f));
        GL.Vertex(new Vector3(8, 3));
        GL.Vertex(new Vector3(8, 3));
        GL.Vertex(new Vector3(8, 2.8f));
        GL.Vertex(new Vector3(8, 2.8f));
        GL.Vertex(new Vector3(6, 2.8f));
        GL.Vertex(new Vector3(6, 2.8f));
        GL.Vertex(new Vector3(6, 4));
        GL.Vertex(new Vector3(6, 4));
        GL.Vertex(new Vector3(3, 4));
        GL.Vertex(new Vector3(3, 4));
        GL.Vertex(new Vector3(3, 2.8f));
        GL.Vertex(new Vector3(3, 2.8f));
        GL.Vertex(new Vector3(1, 2.8f));
        GL.Vertex(new Vector3(1, 2.8f));
        GL.Vertex(new Vector3(1, 3f));
        GL.Vertex(new Vector3(1, 3f));
        GL.Vertex(new Vector3(0, 2.5f));
    }

    private void GeraEstrela()
    {
        GL.Vertex(new Vector3(0, 0));
        GL.Vertex(new Vector3(2.5f, 1.5f));
        GL.Vertex(new Vector3(2.5f, 1.5f));
        GL.Vertex(new Vector3(5, 0));
        GL.Vertex(new Vector3(5, 0));
        GL.Vertex(new Vector3(4, 3));
        GL.Vertex(new Vector3(4, 3));
        GL.Vertex(new Vector3(6, 4));
        GL.Vertex(new Vector3(6, 4));
        GL.Vertex(new Vector3(3.5f, 4));
        GL.Vertex(new Vector3(3.5f, 4));
        GL.Vertex(new Vector3(2.5f, 5));
        GL.Vertex(new Vector3(2.5f, 5));
        GL.Vertex(new Vector3(1.5f, 4));
        GL.Vertex(new Vector3(1.5f, 4));
        GL.Vertex(new Vector3(-1, 4));
        GL.Vertex(new Vector3(-1, 4));
        GL.Vertex(new Vector3(1, 3));
        GL.Vertex(new Vector3(1, 3));
        GL.Vertex(new Vector3(0, 0));
    }

    private void GeraCantoEsquerdo()
    {
        GL.Vertex(new Vector3(0, 0));
        GL.Vertex(new Vector3(0, 5));
        GL.Vertex(new Vector3(0, 0));
        GL.Vertex(new Vector3(1, 1));
        GL.Vertex(new Vector3(1, 1));
        GL.Vertex(new Vector3(1, 4));
        GL.Vertex(new Vector3(1, 4));
        GL.Vertex(new Vector3(4, 4));
        GL.Vertex(new Vector3(4, 4));
        GL.Vertex(new Vector3(5, 5));
        GL.Vertex(new Vector3(5, 5));
        GL.Vertex(new Vector3(0, 5));
    }

    private void GeraSetaDireita()
    {
        GL.Vertex(new Vector3(0, 2));
        GL.Vertex(new Vector3(0, 4));
        GL.Vertex(new Vector3(0, 2));
        GL.Vertex(new Vector3(4, 2));
        GL.Vertex(new Vector3(0, 4));
        GL.Vertex(new Vector3(4, 4));
        GL.Vertex(new Vector3(4, 4));
        GL.Vertex(new Vector3(4, 5));
        GL.Vertex(new Vector3(4, 5));
        GL.Vertex(new Vector3(5, 3));
        GL.Vertex(new Vector3(5, 3));
        GL.Vertex(new Vector3(4, 1));
        GL.Vertex(new Vector3(4, 1));
        GL.Vertex(new Vector3(4, 2));
    }

    private void GeraX(float altura)
    {

        GL.Vertex(new Vector3((altura/2) - (altura/4),0));
        GL.Vertex(new Vector3((altura / 2) , (altura / 2) - (altura / 4)));

        GL.Vertex(new Vector3((altura / 2), (altura / 2) - (altura / 4)));
        GL.Vertex(new Vector3((altura / 2) + (altura / 4), 0));

        GL.Vertex(new Vector3((altura / 2) + (altura / 4), 0));
        GL.Vertex(new Vector3(altura, altura/4));

        GL.Vertex(new Vector3(altura, altura / 4));
        GL.Vertex(new Vector3((altura/2) + (altura/4), altura / 2));

        GL.Vertex(new Vector3((altura / 2) + (altura / 4), altura / 2));
        GL.Vertex(new Vector3(altura, altura - (altura / 4)));

        GL.Vertex(new Vector3(altura, altura - (altura / 4)));
        GL.Vertex(new Vector3(altura-(altura/4), altura ));

        GL.Vertex(new Vector3(altura - (altura / 4), altura));
        GL.Vertex(new Vector3(altura/2 , altura-(altura/4)));

        GL.Vertex(new Vector3(altura / 2, altura - (altura / 4)));
        GL.Vertex(new Vector3(altura / 2 - (altura/4), altura));

        GL.Vertex(new Vector3(altura / 2 - (altura / 4), altura));
        GL.Vertex(new Vector3(0, altura - (altura / 4)));

        GL.Vertex(new Vector3(0, altura - (altura / 4)));
        GL.Vertex(new Vector3((altura/2) - (altura/4), altura/2));

        GL.Vertex(new Vector3((altura / 2) - (altura / 4), altura / 2));
        GL.Vertex(new Vector3(0, altura / 4));

        GL.Vertex(new Vector3(0, altura / 4));
        GL.Vertex(new Vector3(altura/4, 0));



    }

    private void GeraAlmaco(float lado)
    {
        GeraQuadrado(lado);
        GL.Vertex(new Vector3(lado/10, 0));
        GL.Vertex(new Vector3(lado / 10, lado));

        GL.Vertex(new Vector3(0, lado-(lado/10)));
        GL.Vertex(new Vector3(lado, lado - (lado / 10)));

    }

    /// <param name="lado">Tamanho dos lados do hexagono</param>
    private void GeraHexagono(float lado)
    {
        float radianos = (float)(60 * (Math.PI / 180));
        float tg = (float)Math.Tan(radianos);
        float aresta = ((lado/2) / tg);
        float meiox = lado/2, meioy = lado / 2;

        GL.Vertex(new Vector3(meiox-aresta, 0));
        GL.Vertex(new Vector3(meiox + aresta, 0));

        GL.Vertex(new Vector3(meiox + aresta, 0));
        GL.Vertex(new Vector3(lado, lado/2));

        GL.Vertex(new Vector3(lado, lado / 2));
        GL.Vertex(new Vector3(meiox + aresta, lado));

        GL.Vertex(new Vector3(meiox + aresta, lado));
        GL.Vertex(new Vector3(meiox - aresta, lado));

        GL.Vertex(new Vector3(meiox - aresta, lado));
        GL.Vertex(new Vector3(0, lado / 2));

        GL.Vertex(new Vector3(0, lado / 2));
        GL.Vertex(new Vector3(meiox - aresta, 0));

    }

    private void GeraTrianguloEquilatero(float lado)
    {
        GL.Vertex(new Vector3(0, 0));
        GL.Vertex(new Vector3(lado, 0));
        GL.Vertex(new Vector3(lado, 0));
        GL.Vertex(new Vector3((lado / 2), lado));
        GL.Vertex(new Vector3((lado / 2), lado));
        GL.Vertex(new Vector3(0, 0));
    }

    /// <summary>
    /// Gera 1 quadrado com o tamanho desejado
    /// </summary>
    /// <param name="altura"></param>
    /// <param name="largura"></param>
    public void GeraQuadrado(float lado)
    {


        GL.Vertex(new Vector3(0, 0));
        GL.Vertex(new Vector3(lado, 0));

        GL.Vertex(new Vector3(lado, 0));
        GL.Vertex(new Vector3(lado, lado));

        GL.Vertex(new Vector3(lado, lado));
        GL.Vertex(new Vector3(0, lado));

        GL.Vertex(new Vector3(0, lado));
        GL.Vertex(new Vector3(0, 0));


    }
}
