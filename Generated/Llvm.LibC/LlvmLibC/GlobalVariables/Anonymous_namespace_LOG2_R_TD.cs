using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_19LOG2_R_TDE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::LOG2_R_TD")]
internal static partial class Anonymous_namespace_LOG2_R_TD
{
	[FixedAddressValueType]
	private static InlineArray128_Fputil_TripleDouble __value;

	public unsafe static InlineArray128_Fputil_TripleDouble* Pointer => unchecked((InlineArray128_Fputil_TripleDouble*)Unsafe.AsPointer(ref __value));

	public static InlineArray128_Fputil_TripleDouble Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static Anonymous_namespace_LOG2_R_TD()
	{
		Value = new InlineArrayBuilder<InlineArray128_Fputil_TripleDouble, Fputil_TripleDouble>
		{
			default(Fputil_TripleDouble),
			new Fputil_TripleDouble
			{
				Lo = 2.5115002194057522E-24,
				Mid = -3.2536326009530006E-08,
				Hi = 0.011315345764160156
			},
			new Fputil_TripleDouble
			{
				Lo = -2.5770938818543237E-23,
				Mid = -2.604139789703494E-07,
				Hi = 0.0227203369140625
			},
			new Fputil_TripleDouble
			{
				Lo = -1.2885817481776194E-23,
				Mid = -2.1178611048111095E-07,
				Hi = 0.03421592712402344
			},
			new Fputil_TripleDouble
			{
				Lo = -2.5020610356191944E-23,
				Mid = -3.341295509900561E-07,
				Hi = 0.04580402374267578
			},
			new Fputil_TripleDouble
			{
				Lo = -2.6854830204527764E-24,
				Mid = -8.578357581211971E-08,
				Hi = 0.05748558044433594
			},
			new Fputil_TripleDouble
			{
				Lo = 8.405469495847317E-24,
				Mid = 1.578594770047778E-07,
				Hi = 0.06926250457763672
			},
			new Fputil_TripleDouble
			{
				Lo = -6.6080879563691015E-25,
				Mid = 5.9234194550101275E-08,
				Hi = 0.08113670349121094
			},
			new Fputil_TripleDouble
			{
				Lo = 4.193972825166887E-24,
				Mid = 2.7353210647067594E-07,
				Hi = 0.093109130859375
			},
			new Fputil_TripleDouble
			{
				Lo = 2.2719520389272225E-23,
				Mid = -2.9949686183959234E-07,
				Hi = 0.09913349151611328
			},
			new Fputil_TripleDouble
			{
				Lo = 5.982895923248804E-24,
				Mid = 1.5167547136286897E-07,
				Hi = 0.11125659942626953
			},
			new Fputil_TripleDouble
			{
				Lo = -1.089193045992147E-23,
				Mid = 3.492724026237089E-07,
				Hi = 0.12348270416259766
			},
			new Fputil_TripleDouble
			{
				Lo = 1.3026135580470397E-23,
				Mid = 4.232388611016957E-07,
				Hi = 0.12963485717773438
			},
			new Fputil_TripleDouble
			{
				Lo = -8.354829309132391E-24,
				Mid = -2.6697815805821976E-07,
				Hi = 0.14201927185058594
			},
			new Fputil_TripleDouble
			{
				Lo = 1.7833352022106982E-23,
				Mid = 4.046830661860855E-07,
				Hi = 0.1545095443725586
			},
			new Fputil_TripleDouble
			{
				Lo = -2.5251074576196315E-24,
				Mid = 4.6436747467546315E-08,
				Hi = 0.1607961654663086
			},
			new Fputil_TripleDouble
			{
				Lo = -1.6525470743139051E-24,
				Mid = 8.906406548496791E-08,
				Hi = 0.17345142364501953
			},
			new Fputil_TripleDouble
			{
				Lo = -6.884509734481047E-25,
				Mid = 2.3180515416681456E-08,
				Hi = 0.17982101440429688
			},
			new Fputil_TripleDouble
			{
				Lo = -1.1764474821374859E-26,
				Mid = 5.005384173808031E-09,
				Hi = 0.19264507293701172
			},
			new Fputil_TripleDouble
			{
				Lo = -2.1784292843536867E-23,
				Mid = -3.9430507035803283E-07,
				Hi = 0.19910049438476562
			},
			new Fputil_TripleDouble
			{
				Lo = 1.5202972436287774E-23,
				Mid = 2.726398184313491E-07,
				Hi = 0.21209716796875
			},
			new Fputil_TripleDouble
			{
				Lo = -2.140469581277055E-25,
				Mid = -4.097827288531968E-08,
				Hi = 0.21864032745361328
			},
			new Fputil_TripleDouble
			{
				Lo = -1.84008411563013E-23,
				Mid = 3.3708830801652123E-07,
				Hi = 0.23181533813476562
			},
			new Fputil_TripleDouble
			{
				Lo = 2.0462558859403204E-23,
				Mid = -3.291241668162481E-07,
				Hi = 0.2384490966796875
			},
			new Fputil_TripleDouble
			{
				Lo = 3.5156769845195544E-24,
				Mid = -6.241905013050446E-08,
				Hi = 0.25180721282958984
			},
			new Fputil_TripleDouble
			{
				Lo = 3.331177969353518E-24,
				Mid = -4.641843500728646E-07,
				Hi = 0.2585334777832031
			},
			new Fputil_TripleDouble
			{
				Lo = -1.6496473022019722E-24,
				Mid = 7.766336332071922E-08,
				Hi = 0.2720794677734375
			},
			new Fputil_TripleDouble
			{
				Lo = 1.7117068978870034E-24,
				Mid = -2.888658765404089E-07,
				Hi = 0.2789011001586914
			},
			new Fputil_TripleDouble
			{
				Lo = -3.262417162631737E-24,
				Mid = 2.78537490644484E-07,
				Hi = 0.2857542037963867
			},
			new Fputil_TripleDouble
			{
				Lo = -2.1598874792178762E-23,
				Mid = -2.650160921603968E-07,
				Hi = 0.299560546875
			},
			new Fputil_TripleDouble
			{
				Lo = 1.2637335552520065E-23,
				Mid = 2.0985907320229836E-07,
				Hi = 0.30651283264160156
			},
			new Fputil_TripleDouble
			{
				Lo = 1.6449905920023224E-24,
				Mid = 2.2133187868939126E-08,
				Hi = 0.31349945068359375
			},
			new Fputil_TripleDouble
			{
				Lo = 1.1747932113973452E-24,
				Mid = -7.18909291834578E-08,
				Hi = 0.3275747299194336
			},
			new Fputil_TripleDouble
			{
				Lo = -1.5811219296931014E-23,
				Mid = -2.6197277388441173E-07,
				Hi = 0.33466434478759766
			},
			new Fputil_TripleDouble
			{
				Lo = -8.053210564070447E-24,
				Mid = 2.2531705291907835E-07,
				Hi = 0.34178829193115234
			},
			new Fputil_TripleDouble
			{
				Lo = 1.6555194325397685E-25,
				Mid = -1.6987765908313302E-07,
				Hi = 0.34894847869873047
			},
			new Fputil_TripleDouble
			{
				Lo = 2.3271487938149907E-25,
				Mid = -1.4119074032074064E-07,
				Hi = 0.3561439514160156
			},
			new Fputil_TripleDouble
			{
				Lo = -1.2027508328138845E-23,
				Mid = -2.3580226586910683E-07,
				Hi = 0.37064361572265625
			},
			new Fputil_TripleDouble
			{
				Lo = 2.1288063218546807E-24,
				Mid = 3.732316120144662E-07,
				Hi = 0.3779478073120117
			},
			new Fputil_TripleDouble
			{
				Lo = -2.3528949642749718E-26,
				Mid = 1.0010768347616061E-08,
				Hi = 0.38529014587402344
			},
			new Fputil_TripleDouble
			{
				Lo = 7.930715091547332E-25,
				Mid = 8.516014310279128E-09,
				Hi = 0.392669677734375
			},
			new Fputil_TripleDouble
			{
				Lo = 1.3080373199256747E-23,
				Mid = -1.9875451049232623E-07,
				Hi = 0.4000873565673828
			},
			new Fputil_TripleDouble
			{
				Lo = -9.157274415372305E-24,
				Mid = 3.4412747663104627E-07,
				Hi = 0.4150371551513672
			},
			new Fputil_TripleDouble
			{
				Lo = 8.041905938593009E-25,
				Mid = -1.0286725251758779E-08,
				Hi = 0.42257118225097656
			},
			new Fputil_TripleDouble
			{
				Lo = -2.5245095438450844E-24,
				Mid = 8.167149356458616E-08,
				Hi = 0.4301443099975586
			},
			new Fputil_TripleDouble
			{
				Lo = 4.7764561686297874E-24,
				Mid = 8.371349766069681E-08,
				Hi = 0.4377574920654297
			},
			new Fputil_TripleDouble
			{
				Lo = -2.4243177700460661E-23,
				Mid = 4.198677727840792E-07,
				Hi = 0.44541072845458984
			},
			new Fputil_TripleDouble
			{
				Lo = -9.850671472321468E-24,
				Mid = -3.864013085394534E-07,
				Hi = 0.4531059265136719
			},
			new Fputil_TripleDouble
			{
				Lo = 5.637009556629125E-25,
				Mid = 9.997925640990137E-09,
				Hi = 0.46084117889404297
			},
			new Fputil_TripleDouble
			{
				Lo = -1.1126515812530142E-23,
				Mid = 1.465393519327719E-07,
				Hi = 0.46861839294433594
			},
			new Fputil_TripleDouble
			{
				Lo = 4.482104781567791E-24,
				Mid = 4.7527843634645585E-07,
				Hi = 0.4764375686645508
			},
			new Fputil_TripleDouble
			{
				Lo = 2.5717974682171896E-23,
				Mid = -4.5168736277042597E-07,
				Hi = 0.4843006134033203
			},
			new Fputil_TripleDouble
			{
				Lo = 2.3884294423416386E-23,
				Mid = -2.600107079865888E-07,
				Hi = 0.4922056198120117
			},
			new Fputil_TripleDouble
			{
				Lo = 2.6342377926589277E-24,
				Mid = -3.8232246317303357E-07,
				Hi = 0.5001544952392578
			},
			new Fputil_TripleDouble
			{
				Lo = -4.963301590205419E-24,
				Mid = -3.360147333045278E-07,
				Hi = 0.5081472396850586
			},
			new Fputil_TripleDouble
			{
				Lo = -5.4829501256722486E-24,
				Mid = 3.6958632951340836E-07,
				Hi = 0.5161838531494141
			},
			new Fputil_TripleDouble
			{
				Lo = 6.3724592011356084E-24,
				Mid = 3.260526452137857E-07,
				Hi = 0.524266242980957
			},
			new Fputil_TripleDouble
			{
				Lo = 2.0539190738463635E-24,
				Mid = 4.073731505973885E-08,
				Hi = 0.5323944091796875
			},
			new Fputil_TripleDouble
			{
				Lo = -3.3040439781845508E-25,
				Mid = 2.9617097275050637E-08,
				Hi = 0.5405683517456055
			},
			new Fputil_TripleDouble
			{
				Lo = -7.223675108417125E-24,
				Mid = -1.361853561469326E-07,
				Hi = 0.5487890243530273
			},
			new Fputil_TripleDouble
			{
				Lo = -4.277213923656254E-24,
				Mid = 7.714931857282649E-08,
				Hi = 0.5570564270019531
			},
			new Fputil_TripleDouble
			{
				Lo = 1.029936454258418E-23,
				Mid = 2.589965761485286E-07,
				Hi = 0.5653715133666992
			},
			new Fputil_TripleDouble
			{
				Lo = 9.059709461669421E-26,
				Mid = 8.176320029865858E-09,
				Hi = 0.573735237121582
			},
			new Fputil_TripleDouble
			{
				Lo = 5.51436378741644E-24,
				Mid = -1.13152499419201E-07,
				Hi = 0.5821475982666016
			},
			new Fputil_TripleDouble
			{
				Lo = -2.7864647343880426E-24,
				Mid = 4.670605404313756E-07,
				Hi = 0.5906085968017578
			},
			new Fputil_TripleDouble
			{
				Lo = -2.7864647343880426E-24,
				Mid = 4.670605404313756E-07,
				Hi = 0.5906085968017578
			},
			new Fputil_TripleDouble
			{
				Lo = 9.741809619036247E-24,
				Mid = 4.2364213208545636E-07,
				Hi = 0.5991201400756836
			},
			new Fputil_TripleDouble
			{
				Lo = -1.6613664403170928E-23,
				Mid = 3.491328608048543E-07,
				Hi = 0.6076822280883789
			},
			new Fputil_TripleDouble
			{
				Lo = -2.1297908520957373E-24,
				Mid = -1.0698821238072132E-07,
				Hi = 0.6162958145141602
			},
			new Fputil_TripleDouble
			{
				Lo = -1.998101990039323E-23,
				Mid = -3.306999521001096E-07,
				Hi = 0.6249608993530273
			},
			new Fputil_TripleDouble
			{
				Lo = 1.0481013327772652E-23,
				Mid = 3.0314920374572657E-07,
				Hi = 0.6336774826049805
			},
			new Fputil_TripleDouble
			{
				Lo = 1.0481013327772652E-23,
				Mid = 3.0314920374572657E-07,
				Hi = 0.6336774826049805
			},
			new Fputil_TripleDouble
			{
				Lo = -6.763098405928913E-24,
				Mid = -4.2991105244316596E-07,
				Hi = 0.6424484252929688
			},
			new Fputil_TripleDouble
			{
				Lo = 2.354405472554186E-25,
				Mid = 2.570056307243622E-08,
				Hi = 0.6512718200683594
			},
			new Fputil_TripleDouble
			{
				Lo = 1.6310461541904548E-23,
				Mid = 4.2283559011793503E-07,
				Hi = 0.6601495742797852
			},
			new Fputil_TripleDouble
			{
				Lo = -2.974285206230833E-24,
				Mid = -4.733904958859861E-07,
				Hi = 0.6690835952758789
			},
			new Fputil_TripleDouble
			{
				Lo = 1.1635743969074953E-25,
				Mid = -7.059537016037032E-08,
				Hi = 0.6780719757080078
			},
			new Fputil_TripleDouble
			{
				Lo = 1.1635743969074953E-25,
				Mid = -7.059537016037032E-08,
				Hi = 0.6780719757080078
			},
			new Fputil_TripleDouble
			{
				Lo = -1.0806921717574278E-23,
				Mid = 4.217908399517655E-07,
				Hi = 0.6871166229248047
			},
			new Fputil_TripleDouble
			{
				Lo = -1.1329609263075776E-23,
				Mid = -1.9245200526817728E-07,
				Hi = 0.6962194442749023
			},
			new Fputil_TripleDouble
			{
				Lo = -7.412941553250483E-24,
				Mid = -2.3497561138141003E-07,
				Hi = 0.7053794860839844
			},
			new Fputil_TripleDouble
			{
				Lo = -7.412941553250483E-24,
				Mid = -2.3497561138141003E-07,
				Hi = 0.7053794860839844
			},
			new Fputil_TripleDouble
			{
				Lo = -4.286369605854182E-24,
				Mid = 7.911138447064945E-08,
				Hi = 0.7145977020263672
			},
			new Fputil_TripleDouble
			{
				Lo = -1.1669363115652752E-23,
				Mid = -4.0472492115042643E-07,
				Hi = 0.7238759994506836
			},
			new Fputil_TripleDouble
			{
				Lo = -1.1693494851928575E-24,
				Mid = 3.462248144885867E-08,
				Hi = 0.7332134246826172
			},
			new Fputil_TripleDouble
			{
				Lo = -1.1693494851928575E-24,
				Mid = 3.462248144885867E-08,
				Hi = 0.7332134246826172
			},
			new Fputil_TripleDouble
			{
				Lo = 1.8487298397721926E-23,
				Mid = 2.7223654744758844E-07,
				Hi = 0.7426118850708008
			},
			new Fputil_TripleDouble
			{
				Lo = 1.0594022817312609E-23,
				Mid = 1.5226686372495647E-07,
				Hi = 0.7520723342895508
			},
			new Fputil_TripleDouble
			{
				Lo = 1.0594022817312609E-23,
				Mid = 1.5226686372495647E-07,
				Hi = 0.7520723342895508
			},
			new Fputil_TripleDouble
			{
				Lo = 2.0129459982852808E-23,
				Mid = -4.653382625002929E-07,
				Hi = 0.7615957260131836
			},
			new Fputil_TripleDouble
			{
				Lo = -8.924559535990807E-24,
				Mid = 2.0293673631030563E-07,
				Hi = 0.7711811065673828
			},
			new Fputil_TripleDouble
			{
				Lo = -8.924559535990807E-24,
				Mid = 2.0293673631030563E-07,
				Hi = 0.7711811065673828
			},
			new Fputil_TripleDouble
			{
				Lo = 3.9769239309827424E-24,
				Mid = 1.4256274077213818E-07,
				Hi = 0.7808313369750977
			},
			new Fputil_TripleDouble
			{
				Lo = 1.992016548627551E-24,
				Mid = 2.171347220931422E-07,
				Hi = 0.7905464172363281
			},
			new Fputil_TripleDouble
			{
				Lo = 1.992016548627551E-24,
				Mid = 2.171347220931422E-07,
				Hi = 0.7905464172363281
			},
			new Fputil_TripleDouble
			{
				Lo = -2.4070054390969555E-23,
				Mid = 3.5413824497866235E-07,
				Hi = 0.8003273010253906
			},
			new Fputil_TripleDouble
			{
				Lo = -7.540939479667759E-24,
				Mid = -4.54570935198614E-07,
				Hi = 0.810175895690918
			},
			new Fputil_TripleDouble
			{
				Lo = -7.540939479667759E-24,
				Mid = -4.54570935198614E-07,
				Hi = 0.810175895690918
			},
			new Fputil_TripleDouble
			{
				Lo = 4.996417931406801E-24,
				Mid = -3.375735282185901E-07,
				Hi = 0.8200912475585938
			},
			new Fputil_TripleDouble
			{
				Lo = -1.831454883074461E-23,
				Mid = -2.6541936314415746E-07,
				Hi = 0.8300752639770508
			},
			new Fputil_TripleDouble
			{
				Lo = -1.831454883074461E-23,
				Mid = -2.6541936314415746E-07,
				Hi = 0.8300752639770508
			},
			new Fputil_TripleDouble
			{
				Lo = 1.1157945312123889E-23,
				Mid = -2.353989948853462E-07,
				Hi = 0.8401288986206055
			},
			new Fputil_TripleDouble
			{
				Lo = -4.5524633608813706E-24,
				Mid = -2.2466825628015674E-07,
				Hi = 0.8502531051635742
			},
			new Fputil_TripleDouble
			{
				Lo = -4.5524633608813706E-24,
				Mid = -2.2466825628015674E-07,
				Hi = 0.8502531051635742
			},
			new Fputil_TripleDouble
			{
				Lo = -6.930672514136081E-24,
				Mid = -1.8967906699112454E-07,
				Hi = 0.8604488372802734
			},
			new Fputil_TripleDouble
			{
				Lo = -6.930672514136081E-24,
				Mid = -1.8967906699112454E-07,
				Hi = 0.8604488372802734
			},
			new Fputil_TripleDouble
			{
				Lo = 5.894857252740569E-24,
				Mid = -6.55899859865623E-08,
				Hi = 0.8707170486450195
			},
			new Fputil_TripleDouble
			{
				Lo = 8.395043063520251E-24,
				Mid = 2.3434436366276026E-07,
				Hi = 0.8810586929321289
			},
			new Fputil_TripleDouble
			{
				Lo = 8.395043063520251E-24,
				Mid = 2.3434436366276026E-07,
				Hi = 0.8810586929321289
			},
			new Fputil_TripleDouble
			{
				Lo = -4.675169633804515E-24,
				Mid = -1.3426840342874788E-07,
				Hi = 0.8914756774902344
			},
			new Fputil_TripleDouble
			{
				Lo = -4.675169633804515E-24,
				Mid = -1.3426840342874788E-07,
				Hi = 0.8914756774902344
			},
			new Fputil_TripleDouble
			{
				Lo = -1.8912176801863703E-24,
				Mid = -8.527986265329565E-08,
				Hi = 0.9019680023193359
			},
			new Fputil_TripleDouble
			{
				Lo = -1.6137711974927235E-23,
				Mid = -4.1601840581450405E-07,
				Hi = 0.9125375747680664
			},
			new Fputil_TripleDouble
			{
				Lo = -1.6137711974927235E-23,
				Mid = -4.1601840581450405E-07,
				Hi = 0.9125375747680664
			},
			new Fputil_TripleDouble
			{
				Lo = 7.686750203767737E-25,
				Mid = 8.112743326518463E-09,
				Hi = 0.9231843948364258
			},
			new Fputil_TripleDouble
			{
				Lo = 7.686750203767737E-25,
				Mid = 8.112743326518463E-09,
				Hi = 0.9231843948364258
			},
			new Fputil_TripleDouble
			{
				Lo = 9.322826358626283E-24,
				Mid = 4.396691806920707E-07,
				Hi = 0.9339103698730469
			},
			new Fputil_TripleDouble
			{
				Lo = 9.322826358626283E-24,
				Mid = 4.396691806920707E-07,
				Hi = 0.9339103698730469
			},
			new Fputil_TripleDouble
			{
				Lo = 3.1376328295139848E-24,
				Mid = 1.572722478987645E-07,
				Hi = 0.9447174072265625
			},
			new Fputil_TripleDouble
			{
				Lo = 3.1376328295139848E-24,
				Mid = 1.572722478987645E-07,
				Hi = 0.9447174072265625
			},
			new Fputil_TripleDouble
			{
				Lo = -2.8702339127665392E-24,
				Mid = 3.737445739060969E-07,
				Hi = 0.9556055068969727
			},
			new Fputil_TripleDouble
			{
				Lo = -2.8702339127665392E-24,
				Mid = 3.737445739060969E-07,
				Hi = 0.9556055068969727
			},
			new Fputil_TripleDouble
			{
				Lo = 2.4393784369270266E-23,
				Mid = 4.222296395647324E-07,
				Hi = 0.9665765762329102
			},
			new Fputil_TripleDouble
			{
				Lo = 2.4393784369270266E-23,
				Mid = 4.222296395647324E-07,
				Hi = 0.9665765762329102
			},
			new Fputil_TripleDouble
			{
				Lo = -8.24762755163957E-24,
				Mid = -3.356114623207671E-07,
				Hi = 0.9776325225830078
			},
			new Fputil_TripleDouble
			{
				Lo = -8.24762755163957E-24,
				Mid = -3.356114623207671E-07,
				Hi = 0.9776325225830078
			},
			new Fputil_TripleDouble
			{
				Lo = -5.757954870543501E-24,
				Mid = 3.523037966609121E-07,
				Hi = 0.9887723922729492
			},
			new Fputil_TripleDouble
			{
				Lo = 0.0,
				Mid = 0.0,
				Hi = 1.0
			}
		};
		_ = Pointer;
	}
}
