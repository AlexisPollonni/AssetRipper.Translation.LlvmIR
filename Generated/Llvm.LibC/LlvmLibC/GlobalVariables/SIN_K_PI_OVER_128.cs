using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_17SIN_K_PI_OVER_128E")]
[DemangledName("__llvm_libc_20_1_2_::SIN_K_PI_OVER_128")]
internal static partial class SIN_K_PI_OVER_128
{
	[FixedAddressValueType]
	private static InlineArray256_NumberPair __value;

	public unsafe static InlineArray256_NumberPair* Pointer => unchecked((InlineArray256_NumberPair*)Unsafe.AsPointer(ref __value));

	public static InlineArray256_NumberPair Value
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

	unsafe static SIN_K_PI_OVER_128()
	{
		Value = new InlineArrayBuilder<InlineArray256_NumberPair, NumberPair>
		{
			default(NumberPair),
			new NumberPair
			{
				lo = -9.186849012577878E-20,
				hi = 0.024541228522912288
			},
			new NumberPair
			{
				lo = -6.79610372051828E-19,
				hi = 0.049067674327418015
			},
			new NumberPair
			{
				lo = -2.7784941506273593E-18,
				hi = 0.07356456359966743
			},
			new NumberPair
			{
				lo = -1.634582362244256E-18,
				hi = 0.0980171403295606
			},
			new NumberPair
			{
				lo = 2.8354501489965335E-18,
				hi = 0.1224106751992162
			},
			new NumberPair
			{
				lo = 3.726947147046568E-18,
				hi = 0.14673047445536175
			},
			new NumberPair
			{
				lo = 9.19199801817591E-18,
				hi = 0.17096188876030122
			},
			new NumberPair
			{
				lo = -7.991079068461731E-18,
				hi = 0.19509032201612828
			},
			new NumberPair
			{
				lo = -3.6513812299150776E-19,
				hi = 0.2191012401568698
			},
			new NumberPair
			{
				lo = -8.751431529719663E-18,
				hi = 0.2429801799032639
			},
			new NumberPair
			{
				lo = 2.0941222578826688E-17,
				hi = 0.26671275747489837
			},
			new NumberPair
			{
				lo = -1.892797870777425E-17,
				hi = 0.2902846772544624
			},
			new NumberPair
			{
				lo = 1.4560447299968912E-17,
				hi = 0.31368174039889146
			},
			new NumberPair
			{
				lo = -4.200094003347509E-19,
				hi = 0.33688985339222005
			},
			new NumberPair
			{
				lo = -1.7601687123839282E-17,
				hi = 0.35989503653498817
			},
			new NumberPair
			{
				lo = -1.0050772696461588E-17,
				hi = 0.3826834323650898
			},
			new NumberPair
			{
				lo = 9.911140194289988E-18,
				hi = 0.40524131400498986
			},
			new NumberPair
			{
				lo = 9.411189816295473E-18,
				hi = 0.4275550934302821
			},
			new NumberPair
			{
				lo = 4.883192423203524E-18,
				hi = 0.4496113296546066
			},
			new NumberPair
			{
				lo = 6.516678136069013E-18,
				hi = 0.47139673682599764
			},
			new NumberPair
			{
				lo = -1.0257831676562186E-18,
				hi = 0.49289819222978404
			},
			new NumberPair
			{
				lo = -4.5712707523615624E-17,
				hi = 0.5141027441932218
			},
			new NumberPair
			{
				lo = -5.3683132708358134E-17,
				hi = 0.5349976198870973
			},
			new NumberPair
			{
				lo = 4.709410940561677E-17,
				hi = 0.5555702330196022
			},
			new NumberPair
			{
				lo = -3.7909495458942734E-17,
				hi = 0.5758081914178453
			},
			new NumberPair
			{
				lo = -1.3438641936579467E-17,
				hi = 0.5956993044924334
			},
			new NumberPair
			{
				lo = 2.623141776726695E-17,
				hi = 0.6152315905806268
			},
			new NumberPair
			{
				lo = 1.0420901929280035E-17,
				hi = 0.6343932841636455
			},
			new NumberPair
			{
				lo = 8.569564206002624E-18,
				hi = 0.6531728429537768
			},
			new NumberPair
			{
				lo = -4.048903774929669E-17,
				hi = 0.6715589548470184
			},
			new NumberPair
			{
				lo = -1.588932329480679E-17,
				hi = 0.6895405447370669
			},
			new NumberPair
			{
				lo = -4.833646656726457E-17,
				hi = 0.7071067811865476
			},
			new NumberPair
			{
				lo = 2.9198471334403004E-17,
				hi = 0.7242470829514669
			},
			new NumberPair
			{
				lo = -1.4708616952297345E-17,
				hi = 0.7409511253549591
			},
			new NumberPair
			{
				lo = -1.9909098777335502E-17,
				hi = 0.7572088465064846
			},
			new NumberPair
			{
				lo = -3.256590703364977E-17,
				hi = 0.773010453362737
			},
			new NumberPair
			{
				lo = 3.439699315405971E-17,
				hi = 0.7883464276266062
			},
			new NumberPair
			{
				lo = -3.306060980481491E-17,
				hi = 0.8032075314806449
			},
			new NumberPair
			{
				lo = -1.4883149812426772E-17,
				hi = 0.8175848131515837
			},
			new NumberPair
			{
				lo = 1.4073856984728024E-18,
				hi = 0.8314696123025452
			},
			new NumberPair
			{
				lo = -4.363136029687964E-17,
				hi = 0.8448535652497071
			},
			new NumberPair
			{
				lo = -4.818344793633662E-17,
				hi = 0.8577286100002721
			},
			new NumberPair
			{
				lo = -4.188851086854997E-17,
				hi = 0.8700869911087115
			},
			new NumberPair
			{
				lo = -1.9843248405890562E-17,
				hi = 0.881921264348355
			},
			new NumberPair
			{
				lo = -4.116123915190891E-18,
				hi = 0.8932243011955153
			},
			new NumberPair
			{
				lo = -6.609754468748431E-18,
				hi = 0.9039892931234433
			},
			new NumberPair
			{
				lo = -3.631618252781442E-17,
				hi = 0.9142097557035307
			},
			new NumberPair
			{
				lo = 1.7645047084336677E-17,
				hi = 0.9238795325112867
			},
			new NumberPair
			{
				lo = 4.2041415555384355E-17,
				hi = 0.9329927988347388
			},
			new NumberPair
			{
				lo = -2.789637954769834E-17,
				hi = 0.9415440651830208
			},
			new NumberPair
			{
				lo = -7.55441519280433E-18,
				hi = 0.9495281805930367
			},
			new NumberPair
			{
				lo = 4.05538698618757E-17,
				hi = 0.9569403357322088
			},
			new NumberPair
			{
				lo = 2.646395056122003E-17,
				hi = 0.9637760657954398
			},
			new NumberPair
			{
				lo = 1.8365300348428844E-17,
				hi = 0.970031253194544
			},
			new NumberPair
			{
				lo = -2.5572556081259686E-17,
				hi = 0.9757021300385286
			},
			new NumberPair
			{
				lo = 1.8546939997825006E-17,
				hi = 0.9807852804032304
			},
			new NumberPair
			{
				lo = 2.3155637027900207E-17,
				hi = 0.9852776423889412
			},
			new NumberPair
			{
				lo = -4.098730993704711E-17,
				hi = 0.989176509964781
			},
			new NumberPair
			{
				lo = 3.1093055095428906E-17,
				hi = 0.99247953459871
			},
			new NumberPair
			{
				lo = -4.248691367830441E-17,
				hi = 0.9951847266721969
			},
			new NumberPair
			{
				lo = 9.164769537110173E-18,
				hi = 0.9972904566786902
			},
			new NumberPair
			{
				lo = -1.2291693337075465E-17,
				hi = 0.9987954562051724
			},
			new NumberPair
			{
				lo = -2.985148640379975E-17,
				hi = 0.9996988186962042
			},
			new NumberPair
			{
				lo = 0.0,
				hi = 1.0
			},
			new NumberPair
			{
				lo = -2.985148640379975E-17,
				hi = 0.9996988186962042
			},
			new NumberPair
			{
				lo = -1.2291693337075465E-17,
				hi = 0.9987954562051724
			},
			new NumberPair
			{
				lo = 9.164769537110173E-18,
				hi = 0.9972904566786902
			},
			new NumberPair
			{
				lo = -4.248691367830441E-17,
				hi = 0.9951847266721969
			},
			new NumberPair
			{
				lo = 3.1093055095428906E-17,
				hi = 0.99247953459871
			},
			new NumberPair
			{
				lo = -4.098730993704711E-17,
				hi = 0.989176509964781
			},
			new NumberPair
			{
				lo = 2.3155637027900207E-17,
				hi = 0.9852776423889412
			},
			new NumberPair
			{
				lo = 1.8546939997825006E-17,
				hi = 0.9807852804032304
			},
			new NumberPair
			{
				lo = -2.5572556081259686E-17,
				hi = 0.9757021300385286
			},
			new NumberPair
			{
				lo = 1.8365300348428844E-17,
				hi = 0.970031253194544
			},
			new NumberPair
			{
				lo = 2.646395056122003E-17,
				hi = 0.9637760657954398
			},
			new NumberPair
			{
				lo = 4.05538698618757E-17,
				hi = 0.9569403357322088
			},
			new NumberPair
			{
				lo = -7.55441519280433E-18,
				hi = 0.9495281805930367
			},
			new NumberPair
			{
				lo = -2.789637954769834E-17,
				hi = 0.9415440651830208
			},
			new NumberPair
			{
				lo = 4.2041415555384355E-17,
				hi = 0.9329927988347388
			},
			new NumberPair
			{
				lo = 1.7645047084336677E-17,
				hi = 0.9238795325112867
			},
			new NumberPair
			{
				lo = -3.631618252781442E-17,
				hi = 0.9142097557035307
			},
			new NumberPair
			{
				lo = -6.609754468748431E-18,
				hi = 0.9039892931234433
			},
			new NumberPair
			{
				lo = -4.116123915190891E-18,
				hi = 0.8932243011955153
			},
			new NumberPair
			{
				lo = -1.9843248405890562E-17,
				hi = 0.881921264348355
			},
			new NumberPair
			{
				lo = -4.188851086854997E-17,
				hi = 0.8700869911087115
			},
			new NumberPair
			{
				lo = -4.818344793633662E-17,
				hi = 0.8577286100002721
			},
			new NumberPair
			{
				lo = -4.363136029687964E-17,
				hi = 0.8448535652497071
			},
			new NumberPair
			{
				lo = 1.4073856984728024E-18,
				hi = 0.8314696123025452
			},
			new NumberPair
			{
				lo = -1.4883149812426772E-17,
				hi = 0.8175848131515837
			},
			new NumberPair
			{
				lo = -3.306060980481491E-17,
				hi = 0.8032075314806449
			},
			new NumberPair
			{
				lo = 3.439699315405971E-17,
				hi = 0.7883464276266062
			},
			new NumberPair
			{
				lo = -3.256590703364977E-17,
				hi = 0.773010453362737
			},
			new NumberPair
			{
				lo = -1.9909098777335502E-17,
				hi = 0.7572088465064846
			},
			new NumberPair
			{
				lo = -1.4708616952297345E-17,
				hi = 0.7409511253549591
			},
			new NumberPair
			{
				lo = 2.9198471334403004E-17,
				hi = 0.7242470829514669
			},
			new NumberPair
			{
				lo = -4.833646656726457E-17,
				hi = 0.7071067811865476
			},
			new NumberPair
			{
				lo = -1.588932329480679E-17,
				hi = 0.6895405447370669
			},
			new NumberPair
			{
				lo = -4.048903774929669E-17,
				hi = 0.6715589548470184
			},
			new NumberPair
			{
				lo = 8.569564206002624E-18,
				hi = 0.6531728429537768
			},
			new NumberPair
			{
				lo = 1.0420901929280035E-17,
				hi = 0.6343932841636455
			},
			new NumberPair
			{
				lo = 2.623141776726695E-17,
				hi = 0.6152315905806268
			},
			new NumberPair
			{
				lo = -1.3438641936579467E-17,
				hi = 0.5956993044924334
			},
			new NumberPair
			{
				lo = -3.7909495458942734E-17,
				hi = 0.5758081914178453
			},
			new NumberPair
			{
				lo = 4.709410940561677E-17,
				hi = 0.5555702330196022
			},
			new NumberPair
			{
				lo = -5.3683132708358134E-17,
				hi = 0.5349976198870973
			},
			new NumberPair
			{
				lo = -4.5712707523615624E-17,
				hi = 0.5141027441932218
			},
			new NumberPair
			{
				lo = -1.0257831676562186E-18,
				hi = 0.49289819222978404
			},
			new NumberPair
			{
				lo = 6.516678136069013E-18,
				hi = 0.47139673682599764
			},
			new NumberPair
			{
				lo = 4.883192423203524E-18,
				hi = 0.4496113296546066
			},
			new NumberPair
			{
				lo = 9.411189816295473E-18,
				hi = 0.4275550934302821
			},
			new NumberPair
			{
				lo = 9.911140194289988E-18,
				hi = 0.40524131400498986
			},
			new NumberPair
			{
				lo = -1.0050772696461588E-17,
				hi = 0.3826834323650898
			},
			new NumberPair
			{
				lo = -1.7601687123839282E-17,
				hi = 0.35989503653498817
			},
			new NumberPair
			{
				lo = -4.200094003347509E-19,
				hi = 0.33688985339222005
			},
			new NumberPair
			{
				lo = 1.4560447299968912E-17,
				hi = 0.31368174039889146
			},
			new NumberPair
			{
				lo = -1.892797870777425E-17,
				hi = 0.2902846772544624
			},
			new NumberPair
			{
				lo = 2.0941222578826688E-17,
				hi = 0.26671275747489837
			},
			new NumberPair
			{
				lo = -8.751431529719663E-18,
				hi = 0.2429801799032639
			},
			new NumberPair
			{
				lo = -3.6513812299150776E-19,
				hi = 0.2191012401568698
			},
			new NumberPair
			{
				lo = -7.991079068461731E-18,
				hi = 0.19509032201612828
			},
			new NumberPair
			{
				lo = 9.19199801817591E-18,
				hi = 0.17096188876030122
			},
			new NumberPair
			{
				lo = 3.726947147046568E-18,
				hi = 0.14673047445536175
			},
			new NumberPair
			{
				lo = 2.8354501489965335E-18,
				hi = 0.1224106751992162
			},
			new NumberPair
			{
				lo = -1.634582362244256E-18,
				hi = 0.0980171403295606
			},
			new NumberPair
			{
				lo = -2.7784941506273593E-18,
				hi = 0.07356456359966743
			},
			new NumberPair
			{
				lo = -6.79610372051828E-19,
				hi = 0.049067674327418015
			},
			new NumberPair
			{
				lo = -9.186849012577878E-20,
				hi = 0.024541228522912288
			},
			default(NumberPair),
			new NumberPair
			{
				lo = 9.186849012577878E-20,
				hi = -0.024541228522912288
			},
			new NumberPair
			{
				lo = 6.79610372051828E-19,
				hi = -0.049067674327418015
			},
			new NumberPair
			{
				lo = 2.7784941506273593E-18,
				hi = -0.07356456359966743
			},
			new NumberPair
			{
				lo = 1.634582362244256E-18,
				hi = -0.0980171403295606
			},
			new NumberPair
			{
				lo = -2.8354501489965335E-18,
				hi = -0.1224106751992162
			},
			new NumberPair
			{
				lo = -3.726947147046568E-18,
				hi = -0.14673047445536175
			},
			new NumberPair
			{
				lo = -9.19199801817591E-18,
				hi = -0.17096188876030122
			},
			new NumberPair
			{
				lo = 7.991079068461731E-18,
				hi = -0.19509032201612828
			},
			new NumberPair
			{
				lo = 3.6513812299150776E-19,
				hi = -0.2191012401568698
			},
			new NumberPair
			{
				lo = 8.751431529719663E-18,
				hi = -0.2429801799032639
			},
			new NumberPair
			{
				lo = -2.0941222578826688E-17,
				hi = -0.26671275747489837
			},
			new NumberPair
			{
				lo = 1.892797870777425E-17,
				hi = -0.2902846772544624
			},
			new NumberPair
			{
				lo = -1.4560447299968912E-17,
				hi = -0.31368174039889146
			},
			new NumberPair
			{
				lo = 4.200094003347509E-19,
				hi = -0.33688985339222005
			},
			new NumberPair
			{
				lo = 1.7601687123839282E-17,
				hi = -0.35989503653498817
			},
			new NumberPair
			{
				lo = 1.0050772696461588E-17,
				hi = -0.3826834323650898
			},
			new NumberPair
			{
				lo = -9.911140194289988E-18,
				hi = -0.40524131400498986
			},
			new NumberPair
			{
				lo = -9.411189816295473E-18,
				hi = -0.4275550934302821
			},
			new NumberPair
			{
				lo = -4.883192423203524E-18,
				hi = -0.4496113296546066
			},
			new NumberPair
			{
				lo = -6.516678136069013E-18,
				hi = -0.47139673682599764
			},
			new NumberPair
			{
				lo = 1.0257831676562186E-18,
				hi = -0.49289819222978404
			},
			new NumberPair
			{
				lo = 4.5712707523615624E-17,
				hi = -0.5141027441932218
			},
			new NumberPair
			{
				lo = 5.3683132708358134E-17,
				hi = -0.5349976198870973
			},
			new NumberPair
			{
				lo = -4.709410940561677E-17,
				hi = -0.5555702330196022
			},
			new NumberPair
			{
				lo = 3.7909495458942734E-17,
				hi = -0.5758081914178453
			},
			new NumberPair
			{
				lo = 1.3438641936579467E-17,
				hi = -0.5956993044924334
			},
			new NumberPair
			{
				lo = -2.623141776726695E-17,
				hi = -0.6152315905806268
			},
			new NumberPair
			{
				lo = -1.0420901929280035E-17,
				hi = -0.6343932841636455
			},
			new NumberPair
			{
				lo = -8.569564206002624E-18,
				hi = -0.6531728429537768
			},
			new NumberPair
			{
				lo = 4.048903774929669E-17,
				hi = -0.6715589548470184
			},
			new NumberPair
			{
				lo = 1.588932329480679E-17,
				hi = -0.6895405447370669
			},
			new NumberPair
			{
				lo = 4.833646656726457E-17,
				hi = -0.7071067811865476
			},
			new NumberPair
			{
				lo = -2.9198471334403004E-17,
				hi = -0.7242470829514669
			},
			new NumberPair
			{
				lo = 1.4708616952297345E-17,
				hi = -0.7409511253549591
			},
			new NumberPair
			{
				lo = 1.9909098777335502E-17,
				hi = -0.7572088465064846
			},
			new NumberPair
			{
				lo = 3.256590703364977E-17,
				hi = -0.773010453362737
			},
			new NumberPair
			{
				lo = -3.439699315405971E-17,
				hi = -0.7883464276266062
			},
			new NumberPair
			{
				lo = 3.306060980481491E-17,
				hi = -0.8032075314806449
			},
			new NumberPair
			{
				lo = 1.4883149812426772E-17,
				hi = -0.8175848131515837
			},
			new NumberPair
			{
				lo = -1.4073856984728024E-18,
				hi = -0.8314696123025452
			},
			new NumberPair
			{
				lo = 4.363136029687964E-17,
				hi = -0.8448535652497071
			},
			new NumberPair
			{
				lo = 4.818344793633662E-17,
				hi = -0.8577286100002721
			},
			new NumberPair
			{
				lo = 4.188851086854997E-17,
				hi = -0.8700869911087115
			},
			new NumberPair
			{
				lo = 1.9843248405890562E-17,
				hi = -0.881921264348355
			},
			new NumberPair
			{
				lo = 4.116123915190891E-18,
				hi = -0.8932243011955153
			},
			new NumberPair
			{
				lo = 6.609754468748431E-18,
				hi = -0.9039892931234433
			},
			new NumberPair
			{
				lo = 3.631618252781442E-17,
				hi = -0.9142097557035307
			},
			new NumberPair
			{
				lo = -1.7645047084336677E-17,
				hi = -0.9238795325112867
			},
			new NumberPair
			{
				lo = -4.2041415555384355E-17,
				hi = -0.9329927988347388
			},
			new NumberPair
			{
				lo = 2.789637954769834E-17,
				hi = -0.9415440651830208
			},
			new NumberPair
			{
				lo = 7.55441519280433E-18,
				hi = -0.9495281805930367
			},
			new NumberPair
			{
				lo = -4.05538698618757E-17,
				hi = -0.9569403357322088
			},
			new NumberPair
			{
				lo = -2.646395056122003E-17,
				hi = -0.9637760657954398
			},
			new NumberPair
			{
				lo = -1.8365300348428844E-17,
				hi = -0.970031253194544
			},
			new NumberPair
			{
				lo = 2.5572556081259686E-17,
				hi = -0.9757021300385286
			},
			new NumberPair
			{
				lo = -1.8546939997825006E-17,
				hi = -0.9807852804032304
			},
			new NumberPair
			{
				lo = -2.3155637027900207E-17,
				hi = -0.9852776423889412
			},
			new NumberPair
			{
				lo = 4.098730993704711E-17,
				hi = -0.989176509964781
			},
			new NumberPair
			{
				lo = -3.1093055095428906E-17,
				hi = -0.99247953459871
			},
			new NumberPair
			{
				lo = 4.248691367830441E-17,
				hi = -0.9951847266721969
			},
			new NumberPair
			{
				lo = -9.164769537110173E-18,
				hi = -0.9972904566786902
			},
			new NumberPair
			{
				lo = 1.2291693337075465E-17,
				hi = -0.9987954562051724
			},
			new NumberPair
			{
				lo = 2.985148640379975E-17,
				hi = -0.9996988186962042
			},
			new NumberPair
			{
				lo = 0.0,
				hi = -1.0
			},
			new NumberPair
			{
				lo = 2.985148640379975E-17,
				hi = -0.9996988186962042
			},
			new NumberPair
			{
				lo = 1.2291693337075465E-17,
				hi = -0.9987954562051724
			},
			new NumberPair
			{
				lo = -9.164769537110173E-18,
				hi = -0.9972904566786902
			},
			new NumberPair
			{
				lo = 4.248691367830441E-17,
				hi = -0.9951847266721969
			},
			new NumberPair
			{
				lo = -3.1093055095428906E-17,
				hi = -0.99247953459871
			},
			new NumberPair
			{
				lo = 4.098730993704711E-17,
				hi = -0.989176509964781
			},
			new NumberPair
			{
				lo = -2.3155637027900207E-17,
				hi = -0.9852776423889412
			},
			new NumberPair
			{
				lo = -1.8546939997825006E-17,
				hi = -0.9807852804032304
			},
			new NumberPair
			{
				lo = 2.5572556081259686E-17,
				hi = -0.9757021300385286
			},
			new NumberPair
			{
				lo = -1.8365300348428844E-17,
				hi = -0.970031253194544
			},
			new NumberPair
			{
				lo = -2.646395056122003E-17,
				hi = -0.9637760657954398
			},
			new NumberPair
			{
				lo = -4.05538698618757E-17,
				hi = -0.9569403357322088
			},
			new NumberPair
			{
				lo = 7.55441519280433E-18,
				hi = -0.9495281805930367
			},
			new NumberPair
			{
				lo = 2.789637954769834E-17,
				hi = -0.9415440651830208
			},
			new NumberPair
			{
				lo = -4.2041415555384355E-17,
				hi = -0.9329927988347388
			},
			new NumberPair
			{
				lo = -1.7645047084336677E-17,
				hi = -0.9238795325112867
			},
			new NumberPair
			{
				lo = 3.631618252781442E-17,
				hi = -0.9142097557035307
			},
			new NumberPair
			{
				lo = 6.609754468748431E-18,
				hi = -0.9039892931234433
			},
			new NumberPair
			{
				lo = 4.116123915190891E-18,
				hi = -0.8932243011955153
			},
			new NumberPair
			{
				lo = 1.9843248405890562E-17,
				hi = -0.881921264348355
			},
			new NumberPair
			{
				lo = 4.188851086854997E-17,
				hi = -0.8700869911087115
			},
			new NumberPair
			{
				lo = 4.818344793633662E-17,
				hi = -0.8577286100002721
			},
			new NumberPair
			{
				lo = 4.363136029687964E-17,
				hi = -0.8448535652497071
			},
			new NumberPair
			{
				lo = -1.4073856984728024E-18,
				hi = -0.8314696123025452
			},
			new NumberPair
			{
				lo = 1.4883149812426772E-17,
				hi = -0.8175848131515837
			},
			new NumberPair
			{
				lo = 3.306060980481491E-17,
				hi = -0.8032075314806449
			},
			new NumberPair
			{
				lo = -3.439699315405971E-17,
				hi = -0.7883464276266062
			},
			new NumberPair
			{
				lo = 3.256590703364977E-17,
				hi = -0.773010453362737
			},
			new NumberPair
			{
				lo = 1.9909098777335502E-17,
				hi = -0.7572088465064846
			},
			new NumberPair
			{
				lo = 1.4708616952297345E-17,
				hi = -0.7409511253549591
			},
			new NumberPair
			{
				lo = -2.9198471334403004E-17,
				hi = -0.7242470829514669
			},
			new NumberPair
			{
				lo = 4.833646656726457E-17,
				hi = -0.7071067811865476
			},
			new NumberPair
			{
				lo = 1.588932329480679E-17,
				hi = -0.6895405447370669
			},
			new NumberPair
			{
				lo = 4.048903774929669E-17,
				hi = -0.6715589548470184
			},
			new NumberPair
			{
				lo = -8.569564206002624E-18,
				hi = -0.6531728429537768
			},
			new NumberPair
			{
				lo = -1.0420901929280035E-17,
				hi = -0.6343932841636455
			},
			new NumberPair
			{
				lo = -2.623141776726695E-17,
				hi = -0.6152315905806268
			},
			new NumberPair
			{
				lo = 1.3438641936579467E-17,
				hi = -0.5956993044924334
			},
			new NumberPair
			{
				lo = 3.7909495458942734E-17,
				hi = -0.5758081914178453
			},
			new NumberPair
			{
				lo = -4.709410940561677E-17,
				hi = -0.5555702330196022
			},
			new NumberPair
			{
				lo = 5.3683132708358134E-17,
				hi = -0.5349976198870973
			},
			new NumberPair
			{
				lo = 4.5712707523615624E-17,
				hi = -0.5141027441932218
			},
			new NumberPair
			{
				lo = 1.0257831676562186E-18,
				hi = -0.49289819222978404
			},
			new NumberPair
			{
				lo = -6.516678136069013E-18,
				hi = -0.47139673682599764
			},
			new NumberPair
			{
				lo = -4.883192423203524E-18,
				hi = -0.4496113296546066
			},
			new NumberPair
			{
				lo = -9.411189816295473E-18,
				hi = -0.4275550934302821
			},
			new NumberPair
			{
				lo = -9.911140194289988E-18,
				hi = -0.40524131400498986
			},
			new NumberPair
			{
				lo = 1.0050772696461588E-17,
				hi = -0.3826834323650898
			},
			new NumberPair
			{
				lo = 1.7601687123839282E-17,
				hi = -0.35989503653498817
			},
			new NumberPair
			{
				lo = 4.200094003347509E-19,
				hi = -0.33688985339222005
			},
			new NumberPair
			{
				lo = -1.4560447299968912E-17,
				hi = -0.31368174039889146
			},
			new NumberPair
			{
				lo = 1.892797870777425E-17,
				hi = -0.2902846772544624
			},
			new NumberPair
			{
				lo = -2.0941222578826688E-17,
				hi = -0.26671275747489837
			},
			new NumberPair
			{
				lo = 8.751431529719663E-18,
				hi = -0.2429801799032639
			},
			new NumberPair
			{
				lo = 3.6513812299150776E-19,
				hi = -0.2191012401568698
			},
			new NumberPair
			{
				lo = 7.991079068461731E-18,
				hi = -0.19509032201612828
			},
			new NumberPair
			{
				lo = -9.19199801817591E-18,
				hi = -0.17096188876030122
			},
			new NumberPair
			{
				lo = -3.726947147046568E-18,
				hi = -0.14673047445536175
			},
			new NumberPair
			{
				lo = -2.8354501489965335E-18,
				hi = -0.1224106751992162
			},
			new NumberPair
			{
				lo = 1.634582362244256E-18,
				hi = -0.0980171403295606
			},
			new NumberPair
			{
				lo = 2.7784941506273593E-18,
				hi = -0.07356456359966743
			},
			new NumberPair
			{
				lo = 6.79610372051828E-19,
				hi = -0.049067674327418015
			},
			new NumberPair
			{
				lo = 9.186849012577878E-20,
				hi = -0.024541228522912288
			}
		};
		PointerIndices.Register(Pointer);
	}
}
