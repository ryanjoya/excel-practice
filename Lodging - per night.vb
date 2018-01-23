=IF(B3 = "Domestic",

	IF ( _Fund = 70, "No",
	  (
	      IF(OR(_Fund =10, _Fund=90), "GSA maximum", "$350 maximum")
		  
		  ))
,
	IF (B3 <> "Foreign", "",
	
	  IF(OR(_Fund=10, _Fund=70), "Not Included",
	  
	      IF(_Fund=90, "GSA Maximum, "€350 (or equivalent) maximum")))
		  )
