=IF(B3="Domestic",

	IF(OR(_Fund=30,_Fund=40),"Yes","No")

,
	IF(B3<>"Foreign","",
	
		IF(OR(_Fund=10,_Fund=70),"Not Included","No")))
