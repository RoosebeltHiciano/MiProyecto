#include <stdio.h>
#include <math.h>

/* Par, impar o nulo.
NUM: variable de tipo entero. */
int main(void)
{
    int NUM;
    printf("Ingrese el n�mero: ");
    scanf("%d", &NUM);
    if (NUM == 0)
        printf("\nNulo");
    else if (NUM % 2 == 0)
        printf("\nPar");
    else
        printf("\nImpar");

    return 0;
}
