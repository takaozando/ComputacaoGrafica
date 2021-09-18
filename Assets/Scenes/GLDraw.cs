using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Gerador de formas primitivas
/// Alterar de private para int para habilitar op��o na unity
/// </summary>
public class GLDraw : MonoBehaviour
{
    public Material material;
    public int tamanho=5;
    private int opcao=0;
    public int op2 = 0;
    public float centerx = 0;
    public float centery = 0;
    
    private void OnPostRender()
    {
		 GL.PushMatrix();
		 material.SetPass(0);
         GL.Begin(GL.LINES);
        
        #region switchAtividade01
        switch (opcao)
        {
            case 1:
            GeraQuadrado(tamanho);
                break;
            case 2:
                GeraTrianguloEquilatero(tamanho);
                break;
            case 3:
                GeraHexagono(tamanho);
                break;
            case 4:
                GeraX(tamanho);
                break;
            case 5:
                GeraAlmaco(tamanho);
                break;
            case 6:
                GeraSetaDireita();
                break;
            case 7:
                GeraCantoEsquerdo();
                break;
            case 8:
                GeraEstrela();
                break;
            case 9:
                GeraCaixaComSetasLaterais();
                break;
            case 10:
                GeraQuadradoComNum7();
                break;
            case 11:
                GeraHexagonoComNum4();
                break;
            case 12:
                GeraEstrelaComNum1();
                break;
            case 13:
                GeraPisoQuadrado();
                break;
            case 14:
                GeraCubo(tamanho);
                break;
            case 15:
                GeraDesenhoCasa();
                break;
            default:
                break;
        }
        #endregion
        #region switchAtividade02
        switch (op2)
        {
            case 1:
                GeraCirculo(tamanho,new Vector3(centerx,centery));
                break;
            case 2:
                GeraCilindro(tamanho);
                break;
            case 3:
                //Pendente linha diagonal
                //GeraProibido(tamanho);
                break;
            case 4:
                GeraComprimido(tamanho);
                break;
            case 5:
                GeraRosto(tamanho);
                break;
            case 6:

                break;
            case 7:
                GeraSemicirculo(tamanho,new Vector3(centerx,centery));
                break;
        }
                GL.End();
        GL.PopMatrix();
	}
    #endregion

    #region M�todos Atividade01
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

    private void GeraCubo(float lado)
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
        GL.Vertex(new Vector3(1, 3, 0));
        GL.Vertex(new Vector3(0, 0, 0));

        GL.Vertex(new Vector3(2.5f, 2.5f, 0));
        GL.Vertex(new Vector3(2.5f, 4, 0));

        GL.Vertex(new Vector3(2.5f, 4, 0));
        GL.Vertex(new Vector3(2, 3.5f, 0));

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
        GeraQuadrado(5);
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
        GL.Vertex(new Vector3(0, 0, 0));
        GL.Vertex(new Vector3(2.5f, 2, 0));

        GL.Vertex(new Vector3(2.5f, 2, 0));
        GL.Vertex(new Vector3(5, 0, 0));

        GL.Vertex(new Vector3(5, 0, 0));
        GL.Vertex(new Vector3(4, 3, 0));

        GL.Vertex(new Vector3(4, 3, 0));
        GL.Vertex(new Vector3(6, 4, 0));

        GL.Vertex(new Vector3(6, 4, 0));
        GL.Vertex(new Vector3(3.5f, 4, 0));

        GL.Vertex(new Vector3(3.5f, 4, 0));
        GL.Vertex(new Vector3(2.5f, 6, 0));

        GL.Vertex(new Vector3(2.5f, 6, 0));
        GL.Vertex(new Vector3(1.5f, 4, 0));

        GL.Vertex(new Vector3(1.5f, 4, 0));
        GL.Vertex(new Vector3(-1, 4, 0));

        GL.Vertex(new Vector3(-1, 4, 0));
        GL.Vertex(new Vector3(1, 3, 0));

        GL.Vertex(new Vector3(1, 3, 0));
        GL.Vertex(new Vector3(0, 0, 0));

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

    #endregion
    #region Metodos Atividade02
    public void GeraQuadrado2(float lado)
    {
        GL.Vertex3(0, 0, 0);
        GL.Vertex3(0, 2, 0);
        GL.Vertex3(2, 2, 0);
        GL.Vertex3(2, 0, 0);
    }


    public void GeraTriangulo2(float lado)
    {
        GL.Begin(GL.TRIANGLES);
        GL.Vertex3(lado, 0, 0);
        GL.Vertex3(0, lado, 0);
        GL.Vertex3(0, lado, 0);
    }

    public void GeraCirculo(float tamanho,Vector3 center)
    {
    
        GL.Begin(GL.LINES);

        for (var t = 0.0f; t < (2 * Mathf.PI); t += 0.01f)
        {
            Vector3 ci = (new Vector3(Mathf.Cos(t) * tamanho + center.x, Mathf.Sin(t) * tamanho + center.y, center.z));
            GL.Vertex3(ci.x, ci.y, ci.z);
        }
        GL.End();

    }
    public void GeraCilindro(float tamanho)
    { 
        GL.Begin(GL.LINES);
        Vector3 center = new Vector3(tamanho, tamanho);
        tamanho = tamanho / 2;
        GeraElipse(tamanho);
        GL.End();

        GL.Begin(GL.LINES);

        GL.Vertex(new Vector3(Mathf.Cos(0) * - tamanho + center.x, 0));
        GL.Vertex(new Vector3(Mathf.Cos(0) * - tamanho + center.x, tamanho*2));

        center.y = 0 ;

        for (var t = 0.0f; t < (Mathf.PI); t += 0.01f)
        {
            Vector3 ci = (new Vector3(Mathf.Cos(t) * -tamanho + center.x, Mathf.Sin(t) * (-tamanho / 2) + center.y, center.z));
            GL.Vertex3(ci.x, ci.y, ci.z);
        }

        GL.Vertex(new Vector3(Mathf.Cos((float)Math.PI) * -tamanho + center.x, tamanho * 2));

        GL.End();
    }
    ///Pendente
    //public void GeraProibido(float tamanho)
    //{
    //    GeraCirculo(tamanho,new Vector3(tamanho,tamanho));
    //    GL.Vertex(new Vector3(Mathf.Cos(135) * tamanho , Mathf.Sin(135)));
    //    GL.Vertex(new Vector3( Mathf.Cos(225) * tamanho , Mathf.Sin(225)));
    //}

    public void GeraComprimido(float tamanho)
    {
        GeraCirculo(tamanho, new Vector3(centerx, centery));

        GL.Begin(GL.LINES);
        GL.Vertex(new Vector3(centerx, centery));
        GL.Vertex(new Vector3(centerx, centery +(tamanho)));

        GL.Vertex(new Vector3(centerx, centery));
        GL.Vertex(new Vector3(centerx, centery - (tamanho)));

        GL.Vertex(new Vector3(centerx-tamanho, centery));
        GL.Vertex(new Vector3(centerx+tamanho, centery));


        GL.End();
        //GL.Vertex(new Vector3(tamanho, tamanho + (tamanho / 2)));
        //GL.Vertex(new Vector3(tamanho, tamanho + (tamanho / 2)));
    }
    public void GeraRosto(float tamanho)
    {
        GeraCirculo(tamanho, new Vector3(centerx, centery));
        GeraCirculo(tamanho/5, new Vector3(tamanho/4+centerx, tamanho/2+centery));
        GeraCirculo(tamanho / 5, new Vector3(tamanho / 4-(tamanho/2)+centerx, tamanho / 2+centery));
        GeraSemicirculo(tamanho,new Vector3(centerx,centery));
    }
    
    public void GeraElipse(float tamanho)
    {
        for (var t = 0.0f; t < (2 * Mathf.PI); t += 0.01f)
        {
            Vector3 ci = (new Vector3(Mathf.Cos(t) * tamanho + centerx, Mathf.Sin(t) * (tamanho / 2) + centery));
            GL.Vertex3(ci.x, ci.y, ci.z);
        }
    }
    public void GeraSemicirculo(float tamanho, Vector3 center)
    {
        for (var t = 0.0f; t < (Mathf.PI); t += 0.01f)
        {
            Vector3 ci = (new Vector3(Mathf.Cos(t) * -tamanho + center.x, Mathf.Sin(t) * (-tamanho / 2) + center.y));
            GL.Vertex3(ci.x, ci.y, ci.z);
        }
    }
    #endregion
}
