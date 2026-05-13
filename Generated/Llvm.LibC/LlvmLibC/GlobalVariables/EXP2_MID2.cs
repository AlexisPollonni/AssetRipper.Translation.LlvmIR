using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_9EXP2_MID2E")]
[DemangledName("__llvm_libc_20_1_2_::EXP2_MID2")]
internal static partial class EXP2_MID2
{
	[FixedAddressValueType]
	private static InlineArray64_fputil_TripleDouble __value;

	public unsafe static InlineArray64_fputil_TripleDouble* Pointer => unchecked((InlineArray64_fputil_TripleDouble*)Unsafe.AsPointer(ref __value));

	public static InlineArray64_fputil_TripleDouble Value
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

	unsafe static EXP2_MID2()
	{
		Value = new InlineArrayBuilder<InlineArray64_fputil_TripleDouble, fputil_TripleDouble>
		{
			new fputil_TripleDouble
			{
				lo = 0.0,
				mid = 0.0,
				hi = 1.0
			},
			new fputil_TripleDouble
			{
				lo = 3.772979548850901E-33,
				mid = 9.336185335478462E-17,
				hi = 1.0001692397053021
			},
			new fputil_TripleDouble
			{
				lo = 3.65532984508914E-34,
				mid = -5.141333931318957E-18,
				hi = 1.0003385080526823
			},
			new fputil_TripleDouble
			{
				lo = 5.206464843609872E-34,
				mid = 6.962424022020573E-17,
				hi = 1.0005078050469876
			},
			new fputil_TripleDouble
			{
				lo = 6.981980988270293E-34,
				mid = -5.1151232976856676E-17,
				hi = 1.0006771306930664
			},
			new fputil_TripleDouble
			{
				lo = 2.3697046808396328E-33,
				mid = 8.422990024586487E-17,
				hi = 1.0008464849957674
			},
			new fputil_TripleDouble
			{
				lo = -1.957285518913284E-33,
				mid = -2.824522074776168E-17,
				hi = 1.001015867959941
			},
			new fputil_TripleDouble
			{
				lo = -4.762594601427377E-33,
				mid = -7.180424565592132E-17,
				hi = 1.0011852795904375
			},
			new fputil_TripleDouble
			{
				lo = -1.1464476160847457E-34,
				mid = -1.8973728416792993E-17,
				hi = 1.0013547198921082
			},
			new fputil_TripleDouble
			{
				lo = -9.28795936877474E-34,
				mid = 9.060441067269122E-17,
				hi = 1.0015241888698057
			},
			new fputil_TripleDouble
			{
				lo = 6.0764756068910476E-33,
				mid = -7.17327634990032E-17,
				hi = 1.0016936865283832
			},
			new fputil_TripleDouble
			{
				lo = -3.8544338609778155E-34,
				mid = -1.330719624672266E-17,
				hi = 1.0018632128726943
			},
			new fputil_TripleDouble
			{
				lo = 6.797512556137893E-34,
				mid = 2.5726925943221118E-17,
				hi = 1.002032767907594
			},
			new fputil_TripleDouble
			{
				lo = 2.227409450166476E-33,
				mid = -3.929937785484517E-17,
				hi = 1.002202351637938
			},
			new fputil_TripleDouble
			{
				lo = -1.1579535047606974E-33,
				mid = 8.461377247994717E-17,
				hi = 1.0023719640685822
			},
			new fputil_TripleDouble
			{
				lo = -1.1086772737157575E-33,
				mid = -4.19488324163994E-17,
				hi = 1.0025416052043845
			},
			new fputil_TripleDouble
			{
				lo = -6.580760184135584E-34,
				mid = -3.636615928692264E-17,
				hi = 1.0027112750502025
			},
			new fputil_TripleDouble
			{
				lo = 1.2056091399570568E-33,
				mid = -2.6109440632439383E-17,
				hi = 1.0028809736108952
			},
			new fputil_TripleDouble
			{
				lo = 1.1339321389345606E-33,
				mid = 1.753078477982332E-17,
				hi = 1.0030507008913223
			},
			new fputil_TripleDouble
			{
				lo = -2.6772320276362763E-33,
				mid = 5.753923525628267E-17,
				hi = 1.0032204568963443
			},
			new fputil_TripleDouble
			{
				lo = -3.4840205097597224E-34,
				mid = -8.684922005117956E-18,
				hi = 1.0033902416308227
			},
			new fputil_TripleDouble
			{
				lo = -2.7283847969345938E-34,
				mid = 9.490035430981778E-17,
				hi = 1.0035600550996193
			},
			new fputil_TripleDouble
			{
				lo = 1.0861828097742192E-33,
				mid = -8.710380605818422E-17,
				hi = 1.0037298973075977
			},
			new fputil_TripleDouble
			{
				lo = -2.941447597915759E-33,
				mid = 3.4958916958571545E-17,
				hi = 1.003899768259621
			},
			new fputil_TripleDouble
			{
				lo = 5.6430014272086384E-33,
				mid = 9.753787549840241E-17,
				hi = 1.004069667960554
			},
			new fputil_TripleDouble
			{
				lo = 5.837079438552624E-33,
				mid = -1.0576221196292857E-16,
				hi = 1.0042395964152628
			},
			new fputil_TripleDouble
			{
				lo = 2.179710614158648E-33,
				mid = 4.209188738127126E-17,
				hi = 1.0044095536286128
			},
			new fputil_TripleDouble
			{
				lo = 8.565522731271806E-34,
				mid = -1.6700166857554788E-17,
				hi = 1.0045795396054717
			},
			new fputil_TripleDouble
			{
				lo = 9.285306033313043E-35,
				mid = -1.6231463554124514E-17,
				hi = 1.0047495543507072
			},
			new fputil_TripleDouble
			{
				lo = -4.94345170697773E-34,
				mid = 2.3028539278028117E-17,
				hi = 1.004919597869188
			},
			new fputil_TripleDouble
			{
				lo = -1.4012033809789845E-34,
				mid = 1.6418046976773032E-17,
				hi = 1.0050896701657839
			},
			new fputil_TripleDouble
			{
				lo = -6.4740113980537656E-34,
				mid = 3.7266984318284137E-17,
				hi = 1.005259771245365
			},
			new fputil_TripleDouble
			{
				lo = 2.6919761479528557E-33,
				mid = 9.499186535455032E-17,
				hi = 1.0054299011128027
			},
			new fputil_TripleDouble
			{
				lo = 1.701201324118986E-33,
				mid = -8.680931314444582E-17,
				hi = 1.0056000597729693
			},
			new fputil_TripleDouble
			{
				lo = 1.3192596320961701E-33,
				mid = 4.000547491030117E-17,
				hi = 1.005770247230737
			},
			new fputil_TripleDouble
			{
				lo = 5.873888407364589E-33,
				mid = 7.190499111509974E-17,
				hi = 1.00594046349098
			},
			new fputil_TripleDouble
			{
				lo = -1.0460884247534148E-33,
				mid = -1.3908068671065783E-17,
				hi = 1.006110708558573
			},
			new fputil_TripleDouble
			{
				lo = 9.81687621053627E-34,
				mid = -8.14020864257305E-17,
				hi = 1.006280982438391
			},
			new fputil_TripleDouble
			{
				lo = -2.570746966607375E-33,
				mid = -5.762151043749534E-17,
				hi = 1.00645128513531
			},
			new fputil_TripleDouble
			{
				lo = 3.788070355202934E-33,
				mid = 6.745278477310457E-17,
				hi = 1.0066216166542072
			},
			new fputil_TripleDouble
			{
				lo = -9.634315957566585E-34,
				mid = 1.8998557240346296E-17,
				hi = 1.0067919769999607
			},
			new fputil_TripleDouble
			{
				lo = 5.377391721258965E-34,
				mid = -9.637430032316407E-17,
				hi = 1.006962366177449
			},
			new fputil_TripleDouble
			{
				lo = 6.73461401738596E-34,
				mid = -1.2528654462453979E-17,
				hi = 1.0071327841915512
			},
			new fputil_TripleDouble
			{
				lo = 2.2874877969556466E-33,
				mid = 3.020578887843694E-17,
				hi = 1.007303231047148
			},
			new fputil_TripleDouble
			{
				lo = -2.1500582511853098E-33,
				mid = -4.869394258608565E-17,
				hi = 1.0074737067491204
			},
			new fputil_TripleDouble
			{
				lo = 1.568598557552607E-33,
				mid = 5.224029937687453E-17,
				hi = 1.0076442113023503
			},
			new fputil_TripleDouble
			{
				lo = 2.735252329698607E-33,
				mid = -9.361543551478456E-17,
				hi = 1.0078147447117207
			},
			new fputil_TripleDouble
			{
				lo = 3.9520263557685874E-33,
				mid = -8.65251323306195E-17,
				hi = 1.007985306982115
			},
			new fputil_TripleDouble
			{
				lo = 2.4635520613731786E-33,
				mid = -3.252058756084308E-17,
				hi = 1.0081558981184175
			},
			new fputil_TripleDouble
			{
				lo = -5.548885590198837E-33,
				mid = -9.917232268060914E-17,
				hi = 1.0083265181255139
			},
			new fputil_TripleDouble
			{
				lo = 4.985399171299538E-33,
				mid = -7.136047404162523E-17,
				hi = 1.0084971670082898
			},
			new fputil_TripleDouble
			{
				lo = 1.4969925002704946E-33,
				mid = -1.726868371224322E-17,
				hi = 1.0086678447716324
			},
			new fputil_TripleDouble
			{
				lo = -1.3718039406011832E-33,
				mid = -6.61995469367394E-17,
				hi = 1.0088385514204294
			},
			new fputil_TripleDouble
			{
				lo = -3.0497396995234277E-33,
				mid = 3.5654569015130204E-17,
				hi = 1.0090092869595693
			},
			new fputil_TripleDouble
			{
				lo = 2.3384670048758583E-33,
				mid = 3.717310013708818E-17,
				hi = 1.0091800513939415
			},
			new fputil_TripleDouble
			{
				lo = -2.692545818452654E-33,
				mid = 7.062572406825528E-17,
				hi = 1.0093508447284363
			},
			new fputil_TripleDouble
			{
				lo = 1.1834325402816263E-33,
				mid = -1.432141230342882E-17,
				hi = 1.0095216669679448
			},
			new fputil_TripleDouble
			{
				lo = -7.81531085085694E-34,
				mid = 1.566818801313411E-17,
				hi = 1.0096925181173586
			},
			new fputil_TripleDouble
			{
				lo = 2.2600974619316654E-33,
				mid = -1.1043695780393688E-16,
				hi = 1.0098633981815708
			},
			new fputil_TripleDouble
			{
				lo = -2.782171771272267E-33,
				mid = -5.767317427160398E-17,
				hi = 1.0100343071654745
			},
			new fputil_TripleDouble
			{
				lo = 2.614543106712474E-34,
				mid = 4.835484978440383E-18,
				hi = 1.0102052450739643
			},
			new fputil_TripleDouble
			{
				lo = -5.5816182716601926E-33,
				mid = 7.015121289715442E-17,
				hi = 1.0103762119119353
			},
			new fputil_TripleDouble
			{
				lo = -2.0256356155384454E-34,
				mid = 7.161802873619574E-17,
				hi = 1.0105472076842836
			},
			new fputil_TripleDouble
			{
				lo = 2.1841584500543143E-33,
				mid = 1.050465913408405E-16,
				hi = 1.010718232395906
			}
		};
		PointerIndices.Register(Pointer);
	}
}
