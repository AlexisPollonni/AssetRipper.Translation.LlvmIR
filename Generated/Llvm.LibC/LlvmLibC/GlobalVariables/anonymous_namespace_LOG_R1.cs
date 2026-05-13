using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_16LOG_R1E")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::LOG_R1")]
internal static partial class anonymous_namespace_LOG_R1
{
	[FixedAddressValueType]
	private static InlineArray128_NumberPair __value;

	public unsafe static InlineArray128_NumberPair* Pointer => unchecked((InlineArray128_NumberPair*)Unsafe.AsPointer(ref __value));

	public static InlineArray128_NumberPair Value
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

	unsafe static anonymous_namespace_LOG_R1()
	{
		Value = new InlineArrayBuilder<InlineArray128_NumberPair, NumberPair>
		{
			default(NumberPair),
			new NumberPair
			{
				lo = 2.764708154124904E-19,
				hi = 0.007843177461025893
			},
			new NumberPair
			{
				lo = 1.0021578630528974E-18,
				hi = 0.015748356968139168
			},
			new NumberPair
			{
				lo = -1.5774243488668215E-18,
				hi = 0.023716526617316044
			},
			new NumberPair
			{
				lo = 3.0382263084680858E-18,
				hi = 0.0317486983145803
			},
			new NumberPair
			{
				lo = -3.129547680315208E-18,
				hi = 0.039845908547199674
			},
			new NumberPair
			{
				lo = 1.4390903347292205E-18,
				hi = 0.048009219186360606
			},
			new NumberPair
			{
				lo = -3.2835149805605613E-18,
				hi = 0.05623971832287608
			},
			new NumberPair
			{
				lo = -6.470486661692933E-18,
				hi = 0.06453852113757118
			},
			new NumberPair
			{
				lo = -2.5298812881248404E-18,
				hi = 0.06871389254805181
			},
			new NumberPair
			{
				lo = 2.5654358635266204E-18,
				hi = 0.07711730334443129
			},
			new NumberPair
			{
				lo = 6.769872319991152E-18,
				hi = 0.08559193033540351
			},
			new NumberPair
			{
				lo = -6.273760163689594E-19,
				hi = 0.08985632912186105
			},
			new NumberPair
			{
				lo = -4.439009633675136E-18,
				hi = 0.09844007281325252
			},
			new NumberPair
			{
				lo = -1.73705104015906E-18,
				hi = 0.1070981355563671
			},
			new NumberPair
			{
				lo = 5.685957919022839E-18,
				hi = 0.11145544092532282
			},
			new NumberPair
			{
				lo = -2.8375497328444E-18,
				hi = 0.1202274269981598
			},
			new NumberPair
			{
				lo = -5.808912678940971E-18,
				hi = 0.1246424452072766
			},
			new NumberPair
			{
				lo = -3.664457663660085E-18,
				hi = 0.13353139262452263
			},
			new NumberPair
			{
				lo = -3.082753002960249E-18,
				hi = 0.13800567301944372
			},
			new NumberPair
			{
				lo = -4.46694718500102E-18,
				hi = 0.14701474296180966
			},
			new NumberPair
			{
				lo = 5.1669593684615594E-18,
				hi = 0.15154989812720093
			},
			new NumberPair
			{
				lo = -3.650183553047837E-18,
				hi = 0.16068238169047347
			},
			new NumberPair
			{
				lo = -6.262313551919987E-19,
				hi = 0.16528009093910292
			},
			new NumberPair
			{
				lo = -1.5833038914101321E-18,
				hi = 0.17453941635189968
			},
			new NumberPair
			{
				lo = -1.0785017454858423E-17,
				hi = 0.179201429457711
			},
			new NumberPair
			{
				lo = -7.432164219196925E-18,
				hi = 0.18859116980755003
			},
			new NumberPair
			{
				lo = 4.630440315107144E-18,
				hi = 0.19331931100349597
			},
			new NumberPair
			{
				lo = 3.742843482461439E-18,
				hi = 0.1980699137620938
			},
			new NumberPair
			{
				lo = 1.2053243216686129E-17,
				hi = 0.2076393647782445
			},
			new NumberPair
			{
				lo = -9.63115306272449E-18,
				hi = 0.2124586512141934
			},
			new NumberPair
			{
				lo = 1.6168452453763015E-18,
				hi = 0.2173012756899814
			},
			new NumberPair
			{
				lo = 9.551415762738488E-18,
				hi = 0.22705745063534608
			},
			new NumberPair
			{
				lo = 5.774320510479237E-18,
				hi = 0.23197146543777514
			},
			new NumberPair
			{
				lo = 1.9682402978398164E-18,
				hi = 0.2369097470783577
			},
			new NumberPair
			{
				lo = -3.5869293176775316E-18,
				hi = 0.24187253642048673
			},
			new NumberPair
			{
				lo = 1.361743371748368E-17,
				hi = 0.24686007793152578
			},
			new NumberPair
			{
				lo = 2.502843296152504E-17,
				hi = 0.2569104137850272
			},
			new NumberPair
			{
				lo = 3.769957084925505E-18,
				hi = 0.26197371574157396
			},
			new NumberPair
			{
				lo = -7.32891532732017E-18,
				hi = 0.26706278524904525
			},
			new NumberPair
			{
				lo = 1.9460544362807653E-17,
				hi = 0.27217788591581565
			},
			new NumberPair
			{
				lo = -7.44528405583513E-18,
				hi = 0.27731928541623435
			},
			new NumberPair
			{
				lo = 2.607160616442564E-17,
				hi = 0.2876820724517809
			},
			new NumberPair
			{
				lo = -2.097144388760612E-17,
				hi = 0.2929040164329326
			},
			new NumberPair
			{
				lo = -1.720695867445866E-17,
				hi = 0.29815337231907635
			},
			new NumberPair
			{
				lo = -4.151258540103992E-18,
				hi = 0.3034304294199201
			},
			new NumberPair
			{
				lo = -1.6199186085148102E-17,
				hi = 0.3087354816496133
			},
			new NumberPair
			{
				lo = 7.311073985078525E-18,
				hi = 0.31406882762497584
			},
			new NumberPair
			{
				lo = 1.354256857264811E-18,
				hi = 0.3194307707663612
			},
			new NumberPair
			{
				lo = -3.7162556628635935E-18,
				hi = 0.32482161940123766
			},
			new NumberPair
			{
				lo = -1.0828321637483858E-17,
				hi = 0.33024168687057687
			},
			new NumberPair
			{
				lo = -7.183773020381283E-18,
				hi = 0.33569129163814154
			},
			new NumberPair
			{
				lo = -1.9366790062602867E-17,
				hi = 0.34117075740276714
			},
			new NumberPair
			{
				lo = 1.2904632283500345E-17,
				hi = 0.3466804132137367
			},
			new NumberPair
			{
				lo = 5.7233316949182485E-18,
				hi = 0.3522205935893521
			},
			new NumberPair
			{
				lo = 4.844823767868267E-18,
				hi = 0.3577916386388075
			},
			new NumberPair
			{
				lo = 2.106844752226605E-17,
				hi = 0.3633938941874773
			},
			new NumberPair
			{
				lo = -2.4362468710901017E-17,
				hi = 0.36902771190573336
			},
			new NumberPair
			{
				lo = -3.9243112288632396E-18,
				hi = 0.3746934494414107
			},
			new NumberPair
			{
				lo = -1.7802599561805317E-17,
				hi = 0.38039147055604844
			},
			new NumberPair
			{
				lo = -2.0000766892692867E-17,
				hi = 0.38612214526503347
			},
			new NumberPair
			{
				lo = -2.3272171948746268E-17,
				hi = 0.39188584998178355
			},
			new NumberPair
			{
				lo = -1.067457448873493E-17,
				hi = 0.39768296766610944
			},
			new NumberPair
			{
				lo = 2.654514918604821E-18,
				hi = 0.40351388797690263
			},
			new NumberPair
			{
				lo = -1.1994027281528269E-17,
				hi = 0.4093790074293007
			},
			new NumberPair
			{
				lo = -1.1994027281528269E-17,
				hi = 0.4093790074293007
			},
			new NumberPair
			{
				lo = 2.4106486433372258E-17,
				hi = 0.415278729556489
			},
			new NumberPair
			{
				lo = 2.2407148500765553E-17,
				hi = 0.42121346507630353
			},
			new NumberPair
			{
				lo = 1.7851087862331565E-17,
				hi = 0.42718363206280735
			},
			new NumberPair
			{
				lo = 2.4923987486736457E-18,
				hi = 0.43318965612301924
			},
			new NumberPair
			{
				lo = -2.427258569837063E-17,
				hi = 0.4392319705789819
			},
			new NumberPair
			{
				lo = -2.427258569837063E-17,
				hi = 0.4392319705789819
			},
			new NumberPair
			{
				lo = 7.867102101536607E-18,
				hi = 0.44531101665536404
			},
			new NumberPair
			{
				lo = 1.4289478116296355E-17,
				hi = 0.4514272436728001
			},
			new NumberPair
			{
				lo = 2.558480528798173E-17,
				hi = 0.4575811092471784
			},
			new NumberPair
			{
				lo = -1.4492779301143943E-17,
				hi = 0.4637730794950995
			},
			new NumberPair
			{
				lo = -2.3229412495470032E-17,
				hi = 0.4700036292457356
			},
			new NumberPair
			{
				lo = -2.3229412495470032E-17,
				hi = 0.4700036292457356
			},
			new NumberPair
			{
				lo = 1.8639441945228713E-17,
				hi = 0.47627324225933093
			},
			new NumberPair
			{
				lo = -3.1570216243602197E-19,
				hi = 0.48258241145259567
			},
			new NumberPair
			{
				lo = -7.298935579038195E-18,
				hi = 0.4889316391312544
			},
			new NumberPair
			{
				lo = -7.298935579038195E-18,
				hi = 0.4889316391312544
			},
			new NumberPair
			{
				lo = 1.0369273765482855E-17,
				hi = 0.4953214372300254
			},
			new NumberPair
			{
				lo = 7.564389428626968E-18,
				hi = 0.5017523275603158
			},
			new NumberPair
			{
				lo = -7.588768892523324E-18,
				hi = 0.5082248420659333
			},
			new NumberPair
			{
				lo = -7.588768892523324E-18,
				hi = 0.5082248420659333
			},
			new NumberPair
			{
				lo = 7.867446311535213E-18,
				hi = 0.514739523087127
			},
			new NumberPair
			{
				lo = 2.9212921959474365E-17,
				hi = 0.5212969236332861
			},
			new NumberPair
			{
				lo = 2.9212921959474365E-17,
				hi = 0.5212969236332861
			},
			new NumberPair
			{
				lo = 3.3285403760785623E-17,
				hi = 0.5278976076646381
			},
			new NumberPair
			{
				lo = -4.357768696497742E-17,
				hi = 0.5345421503833068
			},
			new NumberPair
			{
				lo = -4.357768696497742E-17,
				hi = 0.5345421503833068
			},
			new NumberPair
			{
				lo = 1.6706605014060776E-17,
				hi = 0.5412311385341033
			},
			new NumberPair
			{
				lo = 4.2703624971069435E-17,
				hi = 0.5479651707154474
			},
			new NumberPair
			{
				lo = 4.2703624971069435E-17,
				hi = 0.5479651707154474
			},
			new NumberPair
			{
				lo = 1.874269083710547E-17,
				hi = 0.5547448577008262
			},
			new NumberPair
			{
				lo = -1.5688108356895506E-17,
				hi = 0.561570822771226
			},
			new NumberPair
			{
				lo = -1.5688108356895506E-17,
				hi = 0.561570822771226
			},
			new NumberPair
			{
				lo = -1.379063432133071E-17,
				hi = 0.5684437020589881
			},
			new NumberPair
			{
				lo = 5.214321232885128E-17,
				hi = 0.5753641449035618
			},
			new NumberPair
			{
				lo = 5.214321232885128E-17,
				hi = 0.5753641449035618
			},
			new NumberPair
			{
				lo = -1.9626643627806023E-17,
				hi = 0.5823328142196552
			},
			new NumberPair
			{
				lo = -2.3920619442246964E-17,
				hi = 0.5893503868783018
			},
			new NumberPair
			{
				lo = -2.3920619442246964E-17,
				hi = 0.5893503868783018
			},
			new NumberPair
			{
				lo = 9.872420079277536E-18,
				hi = 0.5964175541013942
			},
			new NumberPair
			{
				lo = 9.872420079277536E-18,
				hi = 0.5964175541013942
			},
			new NumberPair
			{
				lo = -2.6893870159130116E-17,
				hi = 0.6035350218702582
			},
			new NumberPair
			{
				lo = 3.1367818172463465E-17,
				hi = 0.6107035113488707
			},
			new NumberPair
			{
				lo = 3.1367818172463465E-17,
				hi = 0.6107035113488707
			},
			new NumberPair
			{
				lo = 1.524328452694178E-17,
				hi = 0.6179237593223578
			},
			new NumberPair
			{
				lo = 1.524328452694178E-17,
				hi = 0.6179237593223578
			},
			new NumberPair
			{
				lo = 1.0592894454709713E-17,
				hi = 0.6251965186514375
			},
			new NumberPair
			{
				lo = -2.1085297878853066E-17,
				hi = 0.6325225587435105
			},
			new NumberPair
			{
				lo = -2.1085297878853066E-17,
				hi = 0.6325225587435105
			},
			new NumberPair
			{
				lo = 3.1794937859343885E-17,
				hi = 0.639902666041133
			},
			new NumberPair
			{
				lo = 3.1794937859343885E-17,
				hi = 0.639902666041133
			},
			new NumberPair
			{
				lo = 4.904308388761765E-17,
				hi = 0.6473376445286511
			},
			new NumberPair
			{
				lo = 4.904308388761765E-17,
				hi = 0.6473376445286511
			},
			new NumberPair
			{
				lo = 2.5548464295814284E-17,
				hi = 0.6548283162578087
			},
			new NumberPair
			{
				lo = 2.5548464295814284E-17,
				hi = 0.6548283162578087
			},
			new NumberPair
			{
				lo = 2.21472949355624E-17,
				hi = 0.6623755218931916
			},
			new NumberPair
			{
				lo = 2.21472949355624E-17,
				hi = 0.6623755218931916
			},
			new NumberPair
			{
				lo = 4.17146573914374E-17,
				hi = 0.6699801212784109
			},
			new NumberPair
			{
				lo = 4.17146573914374E-17,
				hi = 0.6699801212784109
			},
			new NumberPair
			{
				lo = -3.8931744894412815E-17,
				hi = 0.6776429940239801
			},
			new NumberPair
			{
				lo = -3.8931744894412815E-17,
				hi = 0.6776429940239801
			},
			new NumberPair
			{
				lo = 1.5397031675690708E-17,
				hi = 0.6853650401178903
			},
			default(NumberPair)
		};
		PointerIndices.Register(Pointer);
	}
}
