#include <stdio.h>

/* Suma cuadrados.
El programa, al recibir como datos un grupo de enteros positivos, obtiene el cuadrado de los mismos y la suma correspondiente a dichos cuadrados. */
int main(void)
{
    int NUM;
    long CUA, SUC = 0;
    printf("Ingrese un n�mero entero (-0 para terminar): ");
    scanf("%d", &NUM);
    while (NUM != 0)
    {
        CUA = NUM * NUM;
        printf("%d al cuadrado es %ld\n", NUM, CUA);
        SUC = SUC + CUA;
        printf("Ingrese un n�mero entero (-0 para terminar): ");
        scanf("%d", &NUM);
    }
    printf("La suma de los cuadrados es %ld", SUC);

    return 0;
}
