using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_9EXP2_MID2E")]
[DemangledName("__llvm_libc_20_1_2_::EXP2_MID2")]
internal static partial class Llvm_libc_20_1_2_EXP2_MID2
{
	[FixedAddressValueType]
	private static InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble __value;

	public unsafe static InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble* Pointer => unchecked((InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble*)Unsafe.AsPointer(ref __value));

	public static InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble Value
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

	unsafe static Llvm_libc_20_1_2_EXP2_MID2()
	{
		Value = new InlineArrayBuilder<InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble, Llvm_libc_20_1_2_fputil_TripleDouble>
		{
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 0.0,
				Mid = 0.0,
				Hi = 1.0
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 3.772979548850901E-33,
				Mid = 9.336185335478462E-17,
				Hi = 1.0001692397053021
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 3.65532984508914E-34,
				Mid = -5.141333931318957E-18,
				Hi = 1.0003385080526823
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 5.206464843609872E-34,
				Mid = 6.962424022020573E-17,
				Hi = 1.0005078050469876
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 6.981980988270293E-34,
				Mid = -5.1151232976856676E-17,
				Hi = 1.0006771306930664
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 2.3697046808396328E-33,
				Mid = 8.422990024586487E-17,
				Hi = 1.0008464849957674
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -1.957285518913284E-33,
				Mid = -2.824522074776168E-17,
				Hi = 1.001015867959941
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -4.762594601427377E-33,
				Mid = -7.180424565592132E-17,
				Hi = 1.0011852795904375
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -1.1464476160847457E-34,
				Mid = -1.8973728416792993E-17,
				Hi = 1.0013547198921082
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -9.28795936877474E-34,
				Mid = 9.060441067269122E-17,
				Hi = 1.0015241888698057
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 6.0764756068910476E-33,
				Mid = -7.17327634990032E-17,
				Hi = 1.0016936865283832
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -3.8544338609778155E-34,
				Mid = -1.330719624672266E-17,
				Hi = 1.0018632128726943
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 6.797512556137893E-34,
				Mid = 2.5726925943221118E-17,
				Hi = 1.002032767907594
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 2.227409450166476E-33,
				Mid = -3.929937785484517E-17,
				Hi = 1.002202351637938
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -1.1579535047606974E-33,
				Mid = 8.461377247994717E-17,
				Hi = 1.0023719640685822
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -1.1086772737157575E-33,
				Mid = -4.19488324163994E-17,
				Hi = 1.0025416052043845
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -6.580760184135584E-34,
				Mid = -3.636615928692264E-17,
				Hi = 1.0027112750502025
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 1.2056091399570568E-33,
				Mid = -2.6109440632439383E-17,
				Hi = 1.0028809736108952
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 1.1339321389345606E-33,
				Mid = 1.753078477982332E-17,
				Hi = 1.0030507008913223
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -2.6772320276362763E-33,
				Mid = 5.753923525628267E-17,
				Hi = 1.0032204568963443
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -3.4840205097597224E-34,
				Mid = -8.684922005117956E-18,
				Hi = 1.0033902416308227
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -2.7283847969345938E-34,
				Mid = 9.490035430981778E-17,
				Hi = 1.0035600550996193
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 1.0861828097742192E-33,
				Mid = -8.710380605818422E-17,
				Hi = 1.0037298973075977
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -2.941447597915759E-33,
				Mid = 3.4958916958571545E-17,
				Hi = 1.003899768259621
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 5.6430014272086384E-33,
				Mid = 9.753787549840241E-17,
				Hi = 1.004069667960554
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 5.837079438552624E-33,
				Mid = -1.0576221196292857E-16,
				Hi = 1.0042395964152628
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 2.179710614158648E-33,
				Mid = 4.209188738127126E-17,
				Hi = 1.0044095536286128
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 8.565522731271806E-34,
				Mid = -1.6700166857554788E-17,
				Hi = 1.0045795396054717
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 9.285306033313043E-35,
				Mid = -1.6231463554124514E-17,
				Hi = 1.0047495543507072
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -4.94345170697773E-34,
				Mid = 2.3028539278028117E-17,
				Hi = 1.004919597869188
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -1.4012033809789845E-34,
				Mid = 1.6418046976773032E-17,
				Hi = 1.0050896701657839
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -6.4740113980537656E-34,
				Mid = 3.7266984318284137E-17,
				Hi = 1.005259771245365
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 2.6919761479528557E-33,
				Mid = 9.499186535455032E-17,
				Hi = 1.0054299011128027
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 1.701201324118986E-33,
				Mid = -8.680931314444582E-17,
				Hi = 1.0056000597729693
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 1.3192596320961701E-33,
				Mid = 4.000547491030117E-17,
				Hi = 1.005770247230737
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 5.873888407364589E-33,
				Mid = 7.190499111509974E-17,
				Hi = 1.00594046349098
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -1.0460884247534148E-33,
				Mid = -1.3908068671065783E-17,
				Hi = 1.006110708558573
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 9.81687621053627E-34,
				Mid = -8.14020864257305E-17,
				Hi = 1.006280982438391
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -2.570746966607375E-33,
				Mid = -5.762151043749534E-17,
				Hi = 1.00645128513531
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 3.788070355202934E-33,
				Mid = 6.745278477310457E-17,
				Hi = 1.0066216166542072
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -9.634315957566585E-34,
				Mid = 1.8998557240346296E-17,
				Hi = 1.0067919769999607
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 5.377391721258965E-34,
				Mid = -9.637430032316407E-17,
				Hi = 1.006962366177449
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 6.73461401738596E-34,
				Mid = -1.2528654462453979E-17,
				Hi = 1.0071327841915512
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 2.2874877969556466E-33,
				Mid = 3.020578887843694E-17,
				Hi = 1.007303231047148
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -2.1500582511853098E-33,
				Mid = -4.869394258608565E-17,
				Hi = 1.0074737067491204
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 1.568598557552607E-33,
				Mid = 5.224029937687453E-17,
				Hi = 1.0076442113023503
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 2.735252329698607E-33,
				Mid = -9.361543551478456E-17,
				Hi = 1.0078147447117207
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 3.9520263557685874E-33,
				Mid = -8.65251323306195E-17,
				Hi = 1.007985306982115
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 2.4635520613731786E-33,
				Mid = -3.252058756084308E-17,
				Hi = 1.0081558981184175
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -5.548885590198837E-33,
				Mid = -9.917232268060914E-17,
				Hi = 1.0083265181255139
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 4.985399171299538E-33,
				Mid = -7.136047404162523E-17,
				Hi = 1.0084971670082898
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 1.4969925002704946E-33,
				Mid = -1.726868371224322E-17,
				Hi = 1.0086678447716324
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -1.3718039406011832E-33,
				Mid = -6.61995469367394E-17,
				Hi = 1.0088385514204294
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -3.0497396995234277E-33,
				Mid = 3.5654569015130204E-17,
				Hi = 1.0090092869595693
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 2.3384670048758583E-33,
				Mid = 3.717310013708818E-17,
				Hi = 1.0091800513939415
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -2.692545818452654E-33,
				Mid = 7.062572406825528E-17,
				Hi = 1.0093508447284363
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 1.1834325402816263E-33,
				Mid = -1.432141230342882E-17,
				Hi = 1.0095216669679448
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -7.81531085085694E-34,
				Mid = 1.566818801313411E-17,
				Hi = 1.0096925181173586
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 2.2600974619316654E-33,
				Mid = -1.1043695780393688E-16,
				Hi = 1.0098633981815708
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -2.782171771272267E-33,
				Mid = -5.767317427160398E-17,
				Hi = 1.0100343071654745
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 2.614543106712474E-34,
				Mid = 4.835484978440383E-18,
				Hi = 1.0102052450739643
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -5.5816182716601926E-33,
				Mid = 7.015121289715442E-17,
				Hi = 1.0103762119119353
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = -2.0256356155384454E-34,
				Mid = 7.161802873619574E-17,
				Hi = 1.0105472076842836
			},
			new Llvm_libc_20_1_2_fputil_TripleDouble
			{
				Lo = 2.1841584500543143E-33,
				Mid = 1.050465913408405E-16,
				Hi = 1.010718232395906
			}
		};
		PointerIndices.Register(Pointer);
	}
}
