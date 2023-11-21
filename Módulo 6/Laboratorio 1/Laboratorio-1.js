    var x = 10;
    var y = 20;

    /* Test A */
    x = x + x + 1;
    y = y - y - x;

    /* Test B */
    // x = (x - y) + 4;
    // y = 4 + (y + 5);

    /* Test C */
    // x = x * 2 - 4;
    // y = 4 - y * 2;

    /* Test D */
    // x = (20 - x) / y;
    // y = x + 2 / y;

    /* Test E */
    // x = ((1 - x) * (y / 8)) * 4 * 0;
    // y = (x + 3) / x;

    alert("Valor de X: " + x);
    alert("Valor de Y: " + y);
