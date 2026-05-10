using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_9EXP2_MID1E")]
[DemangledName("__llvm_libc_20_1_2_::EXP2_MID1")]
internal static partial class EXP2_MID1
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

	unsafe static EXP2_MID1()
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
				lo = -1.2052777336398203E-33,
				mid = -1.5234778603368577E-17,
				hi = 1.0108892860517005
			},
			new fputil_TripleDouble
			{
				lo = 7.884226564969274E-34,
				mid = 5.109225028973444E-17,
				hi = 1.0218971486541166
			},
			new fputil_TripleDouble
			{
				lo = 4.175476603364996E-34,
				mid = 7.600838874027088E-18,
				hi = 1.0330248790212284
			},
			new fputil_TripleDouble
			{
				lo = -4.330791080574723E-33,
				mid = 8.551889705537965E-17,
				hi = 1.0442737824274138
			},
			new fputil_TripleDouble
			{
				lo = -1.3039672497797838E-34,
				mid = 1.759325738772092E-18,
				hi = 1.0556451783605572
			},
			new fputil_TripleDouble
			{
				lo = 2.487739243230479E-33,
				mid = -7.899853966841582E-17,
				hi = 1.0671404006768237
			},
			new fputil_TripleDouble
			{
				lo = -3.658125801319237E-33,
				mid = -6.656660436056593E-17,
				hi = 1.0787607977571199
			},
			new fputil_TripleDouble
			{
				lo = 2.0170548784884862E-33,
				mid = -3.046782079812471E-17,
				hi = 1.0905077326652577
			},
			new fputil_TripleDouble
			{
				lo = 6.458053975367214E-34,
				mid = 5.2660368715706944E-17,
				hi = 1.102382583307841
			},
			new fputil_TripleDouble
			{
				lo = 1.4757016734400031E-33,
				mid = 1.0410278456845571E-16,
				hi = 1.1143867425958924
			},
			new fputil_TripleDouble
			{
				lo = -5.659166861707162E-34,
				mid = 5.165856758795457E-17,
				hi = 1.1265216186082418
			},
			new fputil_TripleDouble
			{
				lo = -2.0074146328324945E-33,
				mid = 8.912812676025408E-17,
				hi = 1.1387886347566916
			},
			new fputil_TripleDouble
			{
				lo = 8.890919316379272E-34,
				mid = 3.250710218863827E-17,
				hi = 1.1511892299529827
			},
			new fputil_TripleDouble
			{
				lo = 7.197098319876763E-34,
				mid = 3.8292048369240935E-17,
				hi = 1.1637248587775775
			},
			new fputil_TripleDouble
			{
				lo = -1.4884292934336851E-33,
				mid = 5.554203254218079E-17,
				hi = 1.1763969916502812
			},
			new fputil_TripleDouble
			{
				lo = 1.1419596568854534E-33,
				mid = 3.982015231465646E-17,
				hi = 1.189207115002721
			},
			new fputil_TripleDouble
			{
				lo = -3.8568525533690765E-33,
				mid = 6.644981499252301E-17,
				hi = 1.202156731452703
			},
			new fputil_TripleDouble
			{
				lo = 4.717206142884998E-33,
				mid = -7.712630692681488E-17,
				hi = 1.215247359980469
			},
			new fputil_TripleDouble
			{
				lo = 6.1846945365210385E-34,
				mid = -1.89878163130253E-17,
				hi = 1.22848053610687
			},
			new fputil_TripleDouble
			{
				lo = -2.31439910378786E-33,
				mid = 4.658027591836937E-17,
				hi = 1.241857812073484
			},
			new fputil_TripleDouble
			{
				lo = -5.768462643250284E-35,
				mid = -6.7113898212968784E-18,
				hi = 1.255380757024691
			},
			new fputil_TripleDouble
			{
				lo = -5.01723570938719E-35,
				mid = 2.667932131342186E-18,
				hi = 1.2690509571917332
			},
			new fputil_TripleDouble
			{
				lo = 7.251314912828195E-34,
				mid = 1.713594918243561E-17,
				hi = 1.2828700160787783
			},
			new fputil_TripleDouble
			{
				lo = 1.686782464618325E-34,
				mid = 2.5382502794888315E-17,
				hi = 1.2968395546510096
			},
			new fputil_TripleDouble
			{
				lo = -2.1262926674396956E-34,
				mid = -7.181536135519454E-17,
				hi = 1.3109612115247644
			},
			new fputil_TripleDouble
			{
				lo = 7.620214063972604E-34,
				mid = -2.8587312100388614E-17,
				hi = 1.3252366431597413
			},
			new fputil_TripleDouble
			{
				lo = -7.6965798353189925E-34,
				mid = 8.927282594831732E-17,
				hi = 1.339667524053303
			},
			new fputil_TripleDouble
			{
				lo = -2.2407483643739503E-33,
				mid = 7.70094837980299E-17,
				hi = 1.3542555469368927
			},
			new fputil_TripleDouble
			{
				lo = -4.886749587849472E-33,
				mid = 9.593797919118849E-17,
				hi = 1.3690024229745905
			},
			new fputil_TripleDouble
			{
				lo = 5.259541347855243E-34,
				mid = -6.770511658794786E-17,
				hi = 1.383909881963832
			},
			new fputil_TripleDouble
			{
				lo = 3.974651900775057E-33,
				mid = -9.614213209051323E-17,
				hi = 1.3989796725383112
			},
			new fputil_TripleDouble
			{
				lo = 4.1386753086994136E-33,
				mid = -9.667293313452913E-17,
				hi = 1.4142135623730951
			},
			new fputil_TripleDouble
			{
				lo = 3.9649253224338936E-35,
				mid = -1.2031642489053655E-17,
				hi = 1.42961333839197
			},
			new fputil_TripleDouble
			{
				lo = -1.773011958202501E-33,
				mid = -3.0237581349939873E-17,
				hi = 1.4451808069770467
			},
			new fputil_TripleDouble
			{
				lo = -4.809488048900044E-33,
				mid = -5.600377186075216E-17,
				hi = 1.460917794180647
			},
			new fputil_TripleDouble
			{
				lo = -1.2115770452309058E-34,
				mid = -3.483994556892796E-17,
				hi = 1.4768261459394993
			},
			new fputil_TripleDouble
			{
				lo = 2.773263293447805E-34,
				mid = 1.4192920154284036E-17,
				hi = 1.4929077282912648
			},
			new fputil_TripleDouble
			{
				lo = 2.0419170696740344E-34,
				mid = -1.016455327754295E-16,
				hi = 1.5091644275934228
			},
			new fputil_TripleDouble
			{
				lo = -2.993828826371378E-33,
				mid = -1.1024941712342561E-16,
				hi = 1.5255981507445384
			},
			new fputil_TripleDouble
			{
				lo = -9.159956374100367E-34,
				mid = 7.949834809697621E-17,
				hi = 1.5422108254079407
			},
			new fputil_TripleDouble
			{
				lo = 5.942302210453856E-35,
				mid = 3.7812070533575275E-17,
				hi = 1.559004400237837
			},
			new fputil_TripleDouble
			{
				lo = 5.439138515562207E-34,
				mid = -1.0136916471278304E-17,
				hi = 1.5759808451078865
			},
			new fputil_TripleDouble
			{
				lo = 4.608483990349626E-33,
				mid = -1.0094406542311964E-16,
				hi = 1.593142151342267
			},
			new fputil_TripleDouble
			{
				lo = 1.069684778889359E-33,
				mid = 2.4707192569797888E-17,
				hi = 1.6104903319492543
			},
			new fputil_TripleDouble
			{
				lo = 1.861242888133996E-33,
				mid = -6.712955084707084E-17,
				hi = 1.6280274218573478
			},
			new fputil_TripleDouble
			{
				lo = -6.738384988036643E-34,
				mid = -1.0125679913674773E-16,
				hi = 1.645755478153965
			},
			new fputil_TripleDouble
			{
				lo = 2.3778529927676503E-33,
				mid = 5.8909926967131E-17,
				hi = 1.6636765803267364
			},
			new fputil_TripleDouble
			{
				lo = 5.103515194728093E-33,
				mid = 8.199010020581497E-17,
				hi = 1.681792830507429
			},
			new fputil_TripleDouble
			{
				lo = 4.508946750518465E-34,
				mid = -8.0237193703977E-18,
				hi = 1.7001063537185235
			},
			new fputil_TripleDouble
			{
				lo = 6.41562962530571E-34,
				mid = -1.851380418263111E-17,
				hi = 1.718619298122478
			},
			new fputil_TripleDouble
			{
				lo = 2.4681208652463518E-33,
				mid = 3.164389299292957E-17,
				hi = 1.7373338352737062
			},
			new fputil_TripleDouble
			{
				lo = 1.2334822744893002E-33,
				mid = 2.960140695448873E-17,
				hi = 1.7562521603732995
			},
			new fputil_TripleDouble
			{
				lo = -3.059030381961223E-33,
				mid = 6.429731796556572E-17,
				hi = 1.7753764925265212
			},
			new fputil_TripleDouble
			{
				lo = 1.4217643387469497E-33,
				mid = 1.8227458427912087E-17,
				hi = 1.7947090750031072
			},
			new fputil_TripleDouble
			{
				lo = -5.862249143774918E-33,
				mid = -9.969531538920349E-17,
				hi = 1.8142521755003989
			},
			new fputil_TripleDouble
			{
				lo = -6.4250893479530425E-34,
				mid = 3.283107224245627E-17,
				hi = 1.8340080864093424
			},
			new fputil_TripleDouble
			{
				lo = 4.614815772055665E-33,
				mid = 9.761887490727594E-17,
				hi = 1.8539791250833855
			},
			new fputil_TripleDouble
			{
				lo = 5.285885594025074E-33,
				mid = -6.122763413004143E-17,
				hi = 1.8741676341103
			},
			new fputil_TripleDouble
			{
				lo = 1.7247509954934323E-33,
				mid = 3.4034035352165297E-17,
				hi = 1.8945759815869656
			},
			new fputil_TripleDouble
			{
				lo = -3.0577697567913255E-33,
				mid = -1.0619946056195963E-16,
				hi = 1.9152065613971474
			},
			new fputil_TripleDouble
			{
				lo = 6.053013676820623E-33,
				mid = 1.0332385960676326E-16,
				hi = 1.9360617934922943
			},
			new fputil_TripleDouble
			{
				lo = -9.632676613618276E-34,
				mid = 8.960767791036668E-17,
				hi = 1.9571441241754002
			},
			new fputil_TripleDouble
			{
				lo = 3.5812037166778622E-34,
				mid = 4.0388753109278167E-17,
				hi = 1.978456026387951
			}
		};
		PointerIndices.Register(Pointer);
	}
}
