=IF(B3="Domestic",IF(_Fund=70,"GSA maximum",(
IF(OR(_Fund=10,_Fund=90),"No","20% of subtotal maximum")

)),
IF(B3<>"FOREIGN","",

IF(OR(_Fund=10,_Fund=70),"Not Included",
IF(_Fund=90,"No","20% of subtotal maximum")))
)
