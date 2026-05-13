using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_8LOG_R_DDE")]
[DemangledName("__llvm_libc_20_1_2_::LOG_R_DD")]
internal static partial class LOG_R_DD
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

	unsafe static LOG_R_DD()
	{
		Value = new InlineArrayBuilder<InlineArray128_NumberPair, NumberPair>
		{
			default(NumberPair),
			new NumberPair
			{
				lo = -1.4902732911301337E-14,
				hi = 0.007843177461040796
			},
			new NumberPair
			{
				lo = -3.527980389655325E-14,
				hi = 0.01574835696817445
			},
			new NumberPair
			{
				lo = -4.730054772033249E-14,
				hi = 0.023716526617363343
			},
			new NumberPair
			{
				lo = 7.580310369375161E-15,
				hi = 0.03174869831457272
			},
			new NumberPair
			{
				lo = -4.9893776716773285E-14,
				hi = 0.039845908547249564
			},
			new NumberPair
			{
				lo = -2.262629393030674E-14,
				hi = 0.048009219186383234
			},
			new NumberPair
			{
				lo = -2.345674491018699E-14,
				hi = 0.056239718322899535
			},
			new NumberPair
			{
				lo = -2.1225608044809997E-14,
				hi = 0.0645385211375924
			},
			new NumberPair
			{
				lo = -3.765296820388875E-14,
				hi = 0.06871389254808946
			},
			new NumberPair
			{
				lo = 5.1128335719851986E-14,
				hi = 0.07711730334438016
			},
			new NumberPair
			{
				lo = -5.046674438470119E-14,
				hi = 0.08559193033545398
			},
			new NumberPair
			{
				lo = 3.1218748807418837E-15,
				hi = 0.08985632912185793
			},
			new NumberPair
			{
				lo = 3.3871241029241416E-14,
				hi = 0.09844007281321865
			},
			new NumberPair
			{
				lo = -1.7376727386423858E-14,
				hi = 0.10709813555638448
			},
			new NumberPair
			{
				lo = 3.957125899799804E-14,
				hi = 0.11145544092528326
			},
			new NumberPair
			{
				lo = -5.2849453521890294E-14,
				hi = 0.12022742699821265
			},
			new NumberPair
			{
				lo = -3.767012502308738E-14,
				hi = 0.12464244520731427
			},
			new NumberPair
			{
				lo = 3.1859736349078334E-14,
				hi = 0.13353139262449076
			},
			new NumberPair
			{
				lo = 5.0900642926060466E-14,
				hi = 0.13800567301939282
			},
			new NumberPair
			{
				lo = 8.710783796122478E-15,
				hi = 0.14701474296180095
			},
			new NumberPair
			{
				lo = 6.157896229122976E-16,
				hi = 0.15154989812720032
			},
			new NumberPair
			{
				lo = 3.821577743916796E-14,
				hi = 0.16068238169043525
			},
			new NumberPair
			{
				lo = 3.9440046718453496E-14,
				hi = 0.16528009093906348
			},
			new NumberPair
			{
				lo = 2.2924522154618074E-14,
				hi = 0.17453941635187675
			},
			new NumberPair
			{
				lo = -3.742530094732263E-14,
				hi = 0.17920142945774842
			},
			new NumberPair
			{
				lo = 2.6693431578015818E-14,
				hi = 0.18859116980752333
			},
			new NumberPair
			{
				lo = -1.0320443688698849E-14,
				hi = 0.1933193110035063
			},
			new NumberPair
			{
				lo = 1.0634128304268335E-14,
				hi = 0.19806991376208316
			},
			new NumberPair
			{
				lo = -4.3425422595242564E-14,
				hi = 0.20763936477828793
			},
			new NumberPair
			{
				lo = -1.2527395755711364E-14,
				hi = 0.21245865121420593
			},
			new NumberPair
			{
				lo = -5.204008743405884E-14,
				hi = 0.21730127569003344
			},
			new NumberPair
			{
				lo = -1.078736749871691E-14,
				hi = 0.22705745063535687
			},
			new NumberPair
			{
				lo = -4.7955860343296286E-14,
				hi = 0.2319714654378231
			},
			new NumberPair
			{
				lo = 5.015686013791602E-16,
				hi = 0.2369097470783572
			},
			new NumberPair
			{
				lo = -7.252318953240293E-16,
				hi = 0.24187253642048745
			},
			new NumberPair
			{
				lo = 2.4688324156011588E-14,
				hi = 0.2468600779315011
			},
			new NumberPair
			{
				lo = 5.465121253624792E-15,
				hi = 0.2569104137850218
			},
			new NumberPair
			{
				lo = 4.102651071698446E-14,
				hi = 0.26197371574153294
			},
			new NumberPair
			{
				lo = -4.996736502345936E-14,
				hi = 0.2670627852490952
			},
			new NumberPair
			{
				lo = 4.903580708156347E-14,
				hi = 0.27217788591576664
			},
			new NumberPair
			{
				lo = 5.089628039500759E-14,
				hi = 0.27731928541618345
			},
			new NumberPair
			{
				lo = 5.076326383153408E-14,
				hi = 0.28768207245173016
			},
			new NumberPair
			{
				lo = 4.727452940514406E-14,
				hi = 0.29290401643288533
			},
			new NumberPair
			{
				lo = -4.4204083338755686E-14,
				hi = 0.29815337231912054
			},
			new NumberPair
			{
				lo = 1.548345993498083E-14,
				hi = 0.3034304294199046
			},
			new NumberPair
			{
				lo = 2.1522127491642888E-14,
				hi = 0.30873548164959175
			},
			new NumberPair
			{
				lo = 1.1054030169005386E-14,
				hi = 0.3140688276249648
			},
			new NumberPair
			{
				lo = -5.534326352070679E-14,
				hi = 0.31943077076641657
			},
			new NumberPair
			{
				lo = -5.351646604259541E-14,
				hi = 0.3248216194012912
			},
			new NumberPair
			{
				lo = 5.4612144489920215E-14,
				hi = 0.33024168687052224
			},
			new NumberPair
			{
				lo = 2.8136969901227338E-14,
				hi = 0.3356912916381134
			},
			new NumberPair
			{
				lo = -1.156568624616423E-14,
				hi = 0.3411707574027787
			},
			new NumberPair
			{
				lo = -5.277820018864269E-14,
				hi = 0.3466804132137895
			},
			new NumberPair
			{
				lo = 2.953765578672408E-14,
				hi = 0.35222059358932256
			},
			new NumberPair
			{
				lo = 2.0543970779333266E-14,
				hi = 0.35779163863878694
			},
			new NumberPair
			{
				lo = 5.2479106361060915E-14,
				hi = 0.36339389418742485
			},
			new NumberPair
			{
				lo = 4.6049893053233095E-14,
				hi = 0.3690277119056873
			},
			new NumberPair
			{
				lo = -4.1082176222359656E-14,
				hi = 0.3746934494414518
			},
			new NumberPair
			{
				lo = 5.654806050508992E-14,
				hi = 0.3803914705559919
			},
			new NumberPair
			{
				lo = -2.9052332860840534E-14,
				hi = 0.3861221452650625
			},
			new NumberPair
			{
				lo = -2.0784442732439175E-14,
				hi = 0.3918858499818043
			},
			new NumberPair
			{
				lo = -1.877344369065388E-14,
				hi = 0.3976829676661282
			},
			new NumberPair
			{
				lo = -3.935475170804319E-14,
				hi = 0.403513887976942
			},
			new NumberPair
			{
				lo = 3.5126564702104676E-14,
				hi = 0.4093790074292656
			},
			new NumberPair
			{
				lo = 3.5126564702104676E-14,
				hi = 0.4093790074292656
			},
			new NumberPair
			{
				lo = 2.6835992531130904E-14,
				hi = 0.41527872955646217
			},
			new NumberPair
			{
				lo = -3.1063837541003616E-14,
				hi = 0.4212134650763346
			},
			new NumberPair
			{
				lo = 1.4728306164145656E-14,
				hi = 0.42718363206279264
			},
			new NumberPair
			{
				lo = 4.23575007881984E-14,
				hi = 0.4331896561229769
			},
			new NumberPair
			{
				lo = 5.1379053454446376E-14,
				hi = 0.4392319705789305
			},
			new NumberPair
			{
				lo = 5.1379053454446376E-14,
				hi = 0.4392319705789305
			},
			new NumberPair
			{
				lo = -4.5677810361223653E-14,
				hi = 0.44531101665540973
			},
			new NumberPair
			{
				lo = -1.0477318104591432E-14,
				hi = 0.4514272436728106
			},
			new NumberPair
			{
				lo = 3.4386987417436576E-14,
				hi = 0.457581109247144
			},
			new NumberPair
			{
				lo = -2.721495688261748E-14,
				hi = 0.4637730794951267
			},
			new NumberPair
			{
				lo = -1.7009641689260365E-14,
				hi = 0.47000362924575256
			},
			new NumberPair
			{
				lo = -1.7009641689260365E-14,
				hi = 0.47000362924575256
			},
			new NumberPair
			{
				lo = -3.623014231206613E-14,
				hi = 0.4762732422593672
			},
			new NumberPair
			{
				lo = 5.534430207540162E-14,
				hi = 0.4825824114525403
			},
			new NumberPair
			{
				lo = 1.6701557585029567E-14,
				hi = 0.4889316391312377
			},
			new NumberPair
			{
				lo = 1.6701557585029567E-14,
				hi = 0.4889316391312377
			},
			new NumberPair
			{
				lo = 7.337841236291517E-15,
				hi = 0.4953214372300181
			},
			new NumberPair
			{
				lo = -9.429331319885203E-15,
				hi = 0.5017523275603253
			},
			new NumberPair
			{
				lo = -9.222439873281322E-15,
				hi = 0.5082248420659425
			},
			new NumberPair
			{
				lo = -9.222439873281322E-15,
				hi = 0.5082248420659425
			},
			new NumberPair
			{
				lo = 3.997589633281717E-14,
				hi = 0.514739523087087
			},
			new NumberPair
			{
				lo = 2.7784788537588388E-14,
				hi = 0.5212969236332583
			},
			new NumberPair
			{
				lo = 2.7784788537588388E-14,
				hi = 0.5212969236332583
			},
			new NumberPair
			{
				lo = 2.501330345782681E-14,
				hi = 0.5278976076646131
			},
			new NumberPair
			{
				lo = -3.823524973407036E-14,
				hi = 0.534542150383345
			},
			new NumberPair
			{
				lo = -3.823524973407036E-14,
				hi = 0.534542150383345
			},
			new NumberPair
			{
				lo = -5.4828310811468674E-14,
				hi = 0.5412311385341582
			},
			new NumberPair
			{
				lo = 1.8472405833748667E-14,
				hi = 0.5479651707154289
			},
			new NumberPair
			{
				lo = 1.8472405833748667E-14,
				hi = 0.5479651707154289
			},
			new NumberPair
			{
				lo = 7.95898808074715E-16,
				hi = 0.5547448577008254
			},
			new NumberPair
			{
				lo = -4.697812205000102E-14,
				hi = 0.561570822771273
			},
			new NumberPair
			{
				lo = -4.697812205000102E-14,
				hi = 0.561570822771273
			},
			new NumberPair
			{
				lo = 1.6861599339981048E-14,
				hi = 0.5684437020589712
			},
			new NumberPair
			{
				lo = -1.2160310058547871E-14,
				hi = 0.575364144903574
			},
			new NumberPair
			{
				lo = -1.2160310058547871E-14,
				hi = 0.575364144903574
			},
			new NumberPair
			{
				lo = 2.917923890401381E-14,
				hi = 0.582332814219626
			},
			new NumberPair
			{
				lo = -2.1007135784857706E-14,
				hi = 0.5893503868783228
			},
			new NumberPair
			{
				lo = -2.1007135784857706E-14,
				hi = 0.5893503868783228
			},
			new NumberPair
			{
				lo = -4.140144639843906E-14,
				hi = 0.5964175541014356
			},
			new NumberPair
			{
				lo = -4.140144639843906E-14,
				hi = 0.5964175541014356
			},
			new NumberPair
			{
				lo = 1.485009465981797E-14,
				hi = 0.6035350218702433
			},
			new NumberPair
			{
				lo = -3.1165899173794433E-14,
				hi = 0.6107035113489019
			},
			new NumberPair
			{
				lo = -3.1165899173794433E-14,
				hi = 0.6107035113489019
			},
			new NumberPair
			{
				lo = -8.311429400161732E-15,
				hi = 0.6179237593223661
			},
			new NumberPair
			{
				lo = -8.311429400161732E-15,
				hi = 0.6179237593223661
			},
			new NumberPair
			{
				lo = -4.0512547504363506E-14,
				hi = 0.6251965186514781
			},
			new NumberPair
			{
				lo = -6.5714011431672766E-15,
				hi = 0.632522558743517
			},
			new NumberPair
			{
				lo = -6.5714011431672766E-15,
				hi = 0.632522558743517
			},
			new NumberPair
			{
				lo = -3.338591810335787E-14,
				hi = 0.6399026660411664
			},
			new NumberPair
			{
				lo = -3.338591810335787E-14,
				hi = 0.6399026660411664
			},
			new NumberPair
			{
				lo = 3.490734460225603E-15,
				hi = 0.6473376445286476
			},
			new NumberPair
			{
				lo = 3.490734460225603E-15,
				hi = 0.6473376445286476
			},
			new NumberPair
			{
				lo = -5.404231283494931E-14,
				hi = 0.6548283162578628
			},
			new NumberPair
			{
				lo = -5.404231283494931E-14,
				hi = 0.6548283162578628
			},
			new NumberPair
			{
				lo = 9.681087609174425E-15,
				hi = 0.6623755218931819
			},
			new NumberPair
			{
				lo = 9.681087609174425E-15,
				hi = 0.6623755218931819
			},
			new NumberPair
			{
				lo = 1.1365989508568034E-14,
				hi = 0.6699801212783996
			},
			new NumberPair
			{
				lo = 1.1365989508568034E-14,
				hi = 0.6699801212783996
			},
			new NumberPair
			{
				lo = 5.32517734371131E-14,
				hi = 0.6776429940239268
			},
			new NumberPair
			{
				lo = 5.32517734371131E-14,
				hi = 0.6776429940239268
			},
			new NumberPair
			{
				lo = 3.19898201408802E-14,
				hi = 0.6853650401178584
			},
			default(NumberPair)
		};
		PointerIndices.Register(Pointer);
	}
}
