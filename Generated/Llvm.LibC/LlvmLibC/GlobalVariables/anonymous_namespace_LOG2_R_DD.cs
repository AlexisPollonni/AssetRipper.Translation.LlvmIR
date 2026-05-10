using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_19LOG2_R_DDE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::LOG2_R_DD")]
internal static partial class anonymous_namespace_LOG2_R_DD
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

	unsafe static anonymous_namespace_LOG2_R_DD()
	{
		Value = new InlineArrayBuilder<InlineArray128_NumberPair, NumberPair>
		{
			default(NumberPair),
			new NumberPair
			{
				lo = -6.254830526910912E-14,
				hi = 0.011315313227896695
			},
			new NumberPair
			{
				lo = -1.800011104506994E-13,
				hi = 0.02272007650026353
			},
			new NumberPair
			{
				lo = 1.9001578577058478E-13,
				hi = 0.03421571533772294
			},
			new NumberPair
			{
				lo = 1.5779993136598194E-13,
				hi = 0.04580368961296699
			},
			new NumberPair
			{
				lo = -3.5540897118851326E-14,
				hi = 0.057485494660795666
			},
			new NumberPair
			{
				lo = -1.5413989669708554E-13,
				hi = 0.06926266243726786
			},
			new NumberPair
			{
				lo = 1.688656831171635E-13,
				hi = 0.08113676272523662
			},
			new NumberPair
			{
				lo = 2.1067041511468125E-13,
				hi = 0.0931094043912708
			},
			new NumberPair
			{
				lo = 1.9820158383567929E-13,
				hi = 0.09913319201905324
			},
			new NumberPair
			{
				lo = -5.055710049459474E-14,
				hi = 0.11125675110179145
			},
			new NumberPair
			{
				lo = 6.1796553011538E-14,
				hi = 0.12348305343493848
			},
			new NumberPair
			{
				lo = 4.466345291637466E-14,
				hi = 0.1296352804165508
			},
			new NumberPair
			{
				lo = -8.107893466726174E-14,
				hi = 0.14201900487250896
			},
			new NumberPair
			{
				lo = 2.1540076490761722E-13,
				hi = 0.15450994905540938
			},
			new NumberPair
			{
				lo = 2.2173177502850943E-13,
				hi = 0.16079621190283433
			},
			new NumberPair
			{
				lo = -2.2175549631774443E-14,
				hi = 0.1734515127091072
			},
			new NumberPair
			{
				lo = 2.2395259483288439E-13,
				hi = 0.17982103758458834
			},
			new NumberPair
			{
				lo = -1.9917399279874596E-14,
				hi = 0.1926450779424158
			},
			new NumberPair
			{
				lo = -8.867292226211853E-15,
				hi = 0.19910010007970413
			},
			new NumberPair
			{
				lo = 1.3693352753699103E-13,
				hi = 0.2120974406084315
			},
			new NumberPair
			{
				lo = -7.960223862778872E-14,
				hi = 0.21864028647542
			},
			new NumberPair
			{
				lo = 1.2961666388058281E-14,
				hi = 0.23181567522306068
			},
			new NumberPair
			{
				lo = 1.3788253208610732E-13,
				hi = 0.2384487675553828
			},
			new NumberPair
			{
				lo = 2.5999522490362272E-14,
				hi = 0.2518071504105137
			},
			new NumberPair
			{
				lo = -8.216080457578053E-14,
				hi = 0.2585330135989352
			},
			new NumberPair
			{
				lo = -2.0825307466611057E-13,
				hi = 0.2720795454370091
			},
			new NumberPair
			{
				lo = 9.993174348495601E-14,
				hi = 0.27890081129271493
			},
			new NumberPair
			{
				lo = 1.9075301583480665E-13,
				hi = 0.2857544823336866
			},
			new NumberPair
			{
				lo = 2.0474716408719944E-13,
				hi = 0.2995602818587031
			},
			new NumberPair
			{
				lo = -8.021541520069169E-15,
				hi = 0.3065130425006828
			},
			new NumberPair
			{
				lo = 1.795539440320528E-13,
				hi = 0.31349947281660206
			},
			new NumberPair
			{
				lo = 7.951818330761124E-14,
				hi = 0.3275746580284249
			},
			new NumberPair
			{
				lo = -1.0099633394713634E-13,
				hi = 0.33466408281492477
			},
			new NumberPair
			{
				lo = 1.9974390575861778E-13,
				hi = 0.3417885172480055
			},
			new NumberPair
			{
				lo = 3.505076895264565E-14,
				hi = 0.34894830882103633
			},
			new NumberPair
			{
				lo = 1.266771905137232E-13,
				hi = 0.3561438102251486
			},
			new NumberPair
			{
				lo = 1.51722805830989E-13,
				hi = 0.37064337992023866
			},
			new NumberPair
			{
				lo = -2.4888447947828258E-15,
				hi = 0.3779481805436262
			},
			new NumberPair
			{
				lo = -3.983479855974919E-14,
				hi = 0.3852901558848316
			},
			new NumberPair
			{
				lo = -3.932977168458341E-14,
				hi = 0.39266968625042864
			},
			new NumberPair
			{
				lo = 9.517021710768741E-14,
				hi = 0.40008715781277715
			},
			new NumberPair
			{
				lo = 1.4733181985781966E-13,
				hi = 0.4150374992786965
			},
			new NumberPair
			{
				lo = 1.1457264392708988E-13,
				hi = 0.42257117196413674
			},
			new NumberPair
			{
				lo = -2.2115992102168893E-13,
				hi = 0.4301443916692733
			},
			new NumberPair
			{
				lo = -3.2669290592879725E-14,
				hi = 0.43775757577896
			},
			new NumberPair
			{
				lo = -1.5420422453235895E-15,
				hi = 0.44541114832236417
			},
			new NumberPair
			{
				lo = -2.1075447043485873E-13,
				hi = 0.4531055401125741
			},
			new NumberPair
			{
				lo = -1.4961559966266254E-13,
				hi = 0.4608411888921182
			},
			new NumberPair
			{
				lo = 2.0134106501930766E-13,
				hi = 0.46861853948348653
			},
			new NumberPair
			{
				lo = 1.520621696507556E-13,
				hi = 0.47643804394283507
			},
			new NumberPair
			{
				lo = -6.808076839265879E-15,
				hi = 0.48430016171596435
			},
			new NumberPair
			{
				lo = 1.8482976480732484E-13,
				hi = 0.4922053598011189
			},
			new NumberPair
			{
				lo = 5.621848729602859E-15,
				hi = 0.500154112916789
			},
			new NumberPair
			{
				lo = -9.67451159139632E-14,
				hi = 0.508146903670422
			},
			new NumberPair
			{
				lo = -3.022519674058776E-14,
				hi = 0.5161842227357738
			},
			new NumberPair
			{
				lo = 1.5887024360595407E-13,
				hi = 0.5242665690334434
			},
			new NumberPair
			{
				lo = 1.3787262762541966E-13,
				hi = 0.5323944499168647
			},
			new NumberPair
			{
				lo = -1.4294083388465032E-13,
				hi = 0.5405683813628457
			},
			new NumberPair
			{
				lo = 1.0675979123384859E-13,
				hi = 0.5487888881675644
			},
			new NumberPair
			{
				lo = 6.625288519055792E-14,
				hi = 0.5570565041512054
			},
			new NumberPair
			{
				lo = 2.2467200272307296E-13,
				hi = 0.5653717723630507
			},
			new NumberPair
			{
				lo = -3.733907276649932E-14,
				hi = 0.5737352452979394
			},
			new NumberPair
			{
				lo = 1.0165123437088802E-14,
				hi = 0.582147485114092
			},
			new NumberPair
			{
				lo = -4.475041293346832E-15,
				hi = 0.5906090638623027
			},
			new NumberPair
			{
				lo = -4.475041293346832E-15,
				hi = 0.5906090638623027
			},
			new NumberPair
			{
				lo = -4.525302271206522E-14,
				hi = 0.5991205637178609
			},
			new NumberPair
			{
				lo = 1.2741442057794507E-13,
				hi = 0.6076825772211123
			},
			new NumberPair
			{
				lo = 1.9686233709301554E-13,
				hi = 0.6162957075257509
			},
			new NumberPair
			{
				lo = 5.216949214960851E-14,
				hi = 0.6249605686530231
			},
			new NumberPair
			{
				lo = 6.772958123003094E-14,
				hi = 0.6336777857541165
			},
			new NumberPair
			{
				lo = 6.772958123003094E-14,
				hi = 0.6336777857541165
			},
			new NumberPair
			{
				lo = -1.82872716976671E-13,
				hi = 0.6424479953820992
			},
			new NumberPair
			{
				lo = 6.178973681288121E-14,
				hi = 0.6512718457688607
			},
			new NumberPair
			{
				lo = 1.3457992854481453E-13,
				hi = 0.6601499971152407
			},
			new NumberPair
			{
				lo = 1.3214477037088102E-13,
				hi = 0.6690831218852509
			},
			new NumberPair
			{
				lo = 6.33385952568616E-14,
				hi = 0.6780719051125743
			},
			new NumberPair
			{
				lo = 6.33385952568616E-14,
				hi = 0.6780719051125743
			},
			new NumberPair
			{
				lo = -6.092125480829092E-14,
				hi = 0.6871170447157056
			},
			new NumberPair
			{
				lo = -1.978889203524144E-13,
				hi = 0.696219251823095
			},
			new NumberPair
			{
				lo = 7.552659103942709E-14,
				hi = 0.7053792511082975
			},
			new NumberPair
			{
				lo = 7.552659103942709E-14,
				hi = 0.7053792511082975
			},
			new NumberPair
			{
				lo = -1.02668366941445E-13,
				hi = 0.7145977811378543
			},
			new NumberPair
			{
				lo = 2.2113852662284353E-13,
				hi = 0.7238755947255413
			},
			new NumberPair
			{
				lo = -1.6285823316452491E-13,
				hi = 0.7332134593052615
			},
			new NumberPair
			{
				lo = -1.6285823316452491E-13,
				hi = 0.7332134593052615
			},
			new NumberPair
			{
				lo = 2.268500031654309E-13,
				hi = 0.7426121573071214
			},
			new NumberPair
			{
				lo = 1.7024883460791358E-13,
				hi = 0.7520724865562443
			},
			new NumberPair
			{
				lo = 1.7024883460791358E-13,
				hi = 0.7520724865562443
			},
			new NumberPair
			{
				lo = 1.5418831696700357E-13,
				hi = 0.7615952606747669
			},
			new NumberPair
			{
				lo = -1.8073834051492126E-13,
				hi = 0.7711813095042999
			},
			new NumberPair
			{
				lo = -1.8073834051492126E-13,
				hi = 0.7711813095042999
			},
			new NumberPair
			{
				lo = -9.898341743527119E-14,
				hi = 0.7808314795379374
			},
			new NumberPair
			{
				lo = 1.3800246976244608E-13,
				hi = 0.7905466343709122
			},
			new NumberPair
			{
				lo = 1.3800246976244608E-13,
				hi = 0.7905466343709122
			},
			new NumberPair
			{
				lo = 1.0749702129807047E-13,
				hi = 0.8003276551635281
			},
			new NumberPair
			{
				lo = -2.6284293846288795E-14,
				hi = 0.810175441120009
			},
			new NumberPair
			{
				lo = -2.6284293846288795E-14,
				hi = 0.810175441120009
			},
			new NumberPair
			{
				lo = -1.7740339410400144E-14,
				hi = 0.8200909099850833
			},
			new NumberPair
			{
				lo = -1.600837111708248E-13,
				hi = 0.8300749985578477
			},
			new NumberPair
			{
				lo = -1.600837111708248E-13,
				hi = 0.8300749985578477
			},
			new NumberPair
			{
				lo = 6.180633020254915E-14,
				hi = 0.8401286632215488
			},
			new NumberPair
			{
				lo = 1.2717265173764345E-13,
				hi = 0.8502528804951908
			},
			new NumberPair
			{
				lo = 1.2717265173764345E-13,
				hi = 0.8502528804951908
			},
			new NumberPair
			{
				lo = 1.4578977761249608E-13,
				hi = 0.8604486476010607
			},
			new NumberPair
			{
				lo = 1.4578977761249608E-13,
				hi = 0.8604486476010607
			},
			new NumberPair
			{
				lo = 4.3421195976986995E-14,
				hi = 0.8707169830549901
			},
			new NumberPair
			{
				lo = -1.3392221040118138E-13,
				hi = 0.8810589272766265
			},
			new NumberPair
			{
				lo = -1.3392221040118138E-13,
				hi = 0.8810589272766265
			},
			new NumberPair
			{
				lo = -1.5535336137788884E-13,
				hi = 0.8914755432219863
			},
			new NumberPair
			{
				lo = -1.5535336137788884E-13,
				hi = 0.8914755432219863
			},
			new NumberPair
			{
				lo = -1.8244685526246436E-13,
				hi = 0.9019679170396557
			},
			new NumberPair
			{
				lo = -6.781363655020842E-14,
				hi = 0.9125371587497284
			},
			new NumberPair
			{
				lo = -6.781363655020842E-14,
				hi = 0.9125371587497284
			},
			new NumberPair
			{
				lo = 5.058670394385646E-14,
				hi = 0.9231844029491185
			},
			new NumberPair
			{
				lo = 5.058670394385646E-14,
				hi = 0.9231844029491185
			},
			new NumberPair
			{
				lo = -1.1228105090517402E-13,
				hi = 0.9339108095423398
			},
			new NumberPair
			{
				lo = -1.1228105090517402E-13,
				hi = 0.9339108095423398
			},
			new NumberPair
			{
				lo = 1.5033143532803899E-13,
				hi = 0.9447175644986601
			},
			new NumberPair
			{
				lo = 1.5033143532803899E-13,
				hi = 0.9447175644986601
			},
			new NumberPair
			{
				lo = 4.390985973169353E-15,
				hi = 0.9556058806415422
			},
			new NumberPair
			{
				lo = 4.390985973169353E-15,
				hi = 0.9556058806415422
			},
			new NumberPair
			{
				lo = -9.250189332390738E-14,
				hi = 0.9665769984626422
			},
			new NumberPair
			{
				lo = -9.250189332390738E-14,
				hi = 0.9665769984626422
			},
			new NumberPair
			{
				lo = -1.8666159154240307E-13,
				hi = 0.9776321869717322
			},
			new NumberPair
			{
				lo = -1.8666159154240307E-13,
				hi = 0.9776321869717322
			},
			new NumberPair
			{
				lo = 1.0999274709132034E-13,
				hi = 0.9887727445766359
			},
			new NumberPair
			{
				lo = 0.0,
				hi = 1.0
			}
		};
		PointerIndices.Register(Pointer);
	}
}
