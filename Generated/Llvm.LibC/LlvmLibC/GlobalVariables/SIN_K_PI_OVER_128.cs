using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
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
				lo = 6.8470254137814494E-18,
				hi = 0.02454122852291228
			},
			new NumberPair
			{
				lo = -6.79610372051828E-19,
				hi = 0.049067674327418015
			},
			new NumberPair
			{
				lo = 2.4977081465001553E-17,
				hi = 0.0735645635996674
			},
			new NumberPair
			{
				lo = -1.634582362244256E-18,
				hi = 0.0980171403295606
			},
			new NumberPair
			{
				lo = -2.492012546663238E-17,
				hi = 0.12241067519921622
			},
			new NumberPair
			{
				lo = -5.178420408421126E-17,
				hi = 0.1467304744553618
			},
			new NumberPair
			{
				lo = -4.631915321308192E-17,
				hi = 0.17096188876030127
			},
			new NumberPair
			{
				lo = -3.574665468409064E-17,
				hi = 0.1950903220161283
			},
			new NumberPair
			{
				lo = -2.812071373862042E-17,
				hi = 0.21910124015686983
			},
			new NumberPair
			{
				lo = -3.6507007145348577E-17,
				hi = 0.24298017990326393
			},
			new NumberPair
			{
				lo = -3.456992865243114E-17,
				hi = 0.2667127574748984
			},
			new NumberPair
			{
				lo = 9.20943237547414E-17,
				hi = 0.2902846772544623
			},
			new NumberPair
			{
				lo = 7.007159853122674E-17,
				hi = 0.3136817403988914
			},
			new NumberPair
			{
				lo = 5.509114183092308E-17,
				hi = 0.33688985339222
			},
			new NumberPair
			{
				lo = -7.311283835509711E-17,
				hi = 0.3598950365349882
			},
			new NumberPair
			{
				lo = -6.556192392771941E-17,
				hi = 0.38268343236508984
			},
			new NumberPair
			{
				lo = -1.0111116226822567E-16,
				hi = 0.40524131400498997
			},
			new NumberPair
			{
				lo = 9.411189816295473E-18,
				hi = 0.4275550934302821
			},
			new NumberPair
			{
				lo = -1.0613911003931213E-16,
				hi = 0.4496113296546067
			},
			new NumberPair
			{
				lo = -4.8994473095188815E-17,
				hi = 0.4713967368259977
			},
			new NumberPair
			{
				lo = 1.0999651929485943E-16,
				hi = 0.4928981922297839
			},
			new NumberPair
			{
				lo = 1.7633189740141568E-16,
				hi = 0.5141027441932216
			},
			new NumberPair
			{
				lo = -1.6470543517087378E-16,
				hi = 0.5349976198870974
			},
			new NumberPair
			{
				lo = 4.709410940561677E-17,
				hi = 0.5555702330196022
			},
			new NumberPair
			{
				lo = -1.489317979214584E-16,
				hi = 0.5758081914178454
			},
			new NumberPair
			{
				lo = 9.758366052593619E-17,
				hi = 0.5956993044924332
			},
			new NumberPair
			{
				lo = 1.372537202297826E-16,
				hi = 0.6152315905806267
			},
			new NumberPair
			{
				lo = -2.1162370299575128E-16,
				hi = 0.6343932841636457
			},
			new NumberPair
			{
				lo = 1.1959186666851827E-16,
				hi = 0.6531728429537766
			},
			new NumberPair
			{
				lo = -4.048903774929669E-17,
				hi = 0.6715589548470184
			},
			new NumberPair
			{
				lo = -1.2691162575732245E-16,
				hi = 0.689540544737067
			},
			new NumberPair
			{
				lo = 6.268583589525109E-17,
				hi = 0.7071067811865475
			},
			new NumberPair
			{
				lo = -1.928461335906283E-16,
				hi = 0.7242470829514671
			},
			new NumberPair
			{
				lo = -1.25730919414813E-16,
				hi = 0.7409511253549592
			},
			new NumberPair
			{
				lo = 2.021355061476958E-16,
				hi = 0.7572088465064843
			},
			new NumberPair
			{
				lo = 7.845639542886589E-17,
				hi = 0.7730104533627369
			},
			new NumberPair
			{
				lo = -7.662530930845594E-17,
				hi = 0.7883464276266063
			},
			new NumberPair
			{
				lo = 7.796169265770074E-17,
				hi = 0.8032075314806448
			},
			new NumberPair
			{
				lo = 2.0716145511260453E-16,
				hi = 0.8175848131515835
			},
			new NumberPair
			{
				lo = -1.0961491676404285E-16,
				hi = 0.8314696123025453
			},
			new NumberPair
			{
				lo = -4.363136029687964E-17,
				hi = 0.8448535652497071
			},
			new NumberPair
			{
				lo = 1.738611569886947E-16,
				hi = 0.8577286100002719
			},
			new NumberPair
			{
				lo = 1.8015609405648135E-16,
				hi = 0.8700869911087112
			},
			new NumberPair
			{
				lo = 9.117905405662509E-17,
				hi = 0.8819212643483549
			},
			new NumberPair
			{
				lo = 1.0690617854732477E-16,
				hi = 0.8932243011955152
			},
			new NumberPair
			{
				lo = -1.1763205693126407E-16,
				hi = 0.9039892931234434
			},
			new NumberPair
			{
				lo = 1.8572842239721687E-16,
				hi = 0.9142097557035305
			},
			new NumberPair
			{
				lo = -2.0439955784069464E-16,
				hi = 0.923879532511287
			},
			new NumberPair
			{
				lo = 4.2041415555384355E-17,
				hi = 0.9329927988347388
			},
			new NumberPair
			{
				lo = 8.312592291481732E-17,
				hi = 0.9415440651830207
			},
			new NumberPair
			{
				lo = 2.1449018973222698E-16,
				hi = 0.9495281805930365
			},
			new NumberPair
			{
				lo = -1.8149073506315562E-16,
				hi = 0.956940335732209
			},
			new NumberPair
			{
				lo = -8.455835190129563E-17,
				hi = 0.96377606579544
			},
			new NumberPair
			{
				lo = -9.265700211408681E-17,
				hi = 0.9700312531945441
			},
			new NumberPair
			{
				lo = 8.544974638125596E-17,
				hi = 0.9757021300385285
			},
			new NumberPair
			{
				lo = 1.8546939997825006E-17,
				hi = 0.9807852804032304
			},
			new NumberPair
			{
				lo = 1.3417793949041587E-16,
				hi = 0.9852776423889411
			},
			new NumberPair
			{
				lo = -1.5200961239956277E-16,
				hi = 0.9891765099647811
			},
			new NumberPair
			{
				lo = -7.992924736708675E-17,
				hi = 0.9924795345987101
			},
			new NumberPair
			{
				lo = 1.795576912467269E-16,
				hi = 0.9951847266721967
			},
			new NumberPair
			{
				lo = -2.1287983538792114E-16,
				hi = 0.9972904566786904
			},
			new NumberPair
			{
				lo = 2.0975291158795585E-16,
				hi = 0.9987954562051722
			},
			new NumberPair
			{
				lo = 8.11708160587159E-17,
				hi = 0.9996988186962041
			},
			new NumberPair
			{
				lo = 0.0,
				hi = 1.0
			},
			new NumberPair
			{
				lo = 8.11708160587159E-17,
				hi = 0.9996988186962041
			},
			new NumberPair
			{
				lo = 2.0975291158795585E-16,
				hi = 0.9987954562051722
			},
			new NumberPair
			{
				lo = -2.1287983538792114E-16,
				hi = 0.9972904566786904
			},
			new NumberPair
			{
				lo = 1.795576912467269E-16,
				hi = 0.9951847266721967
			},
			new NumberPair
			{
				lo = -7.992924736708675E-17,
				hi = 0.9924795345987101
			},
			new NumberPair
			{
				lo = -1.5200961239956277E-16,
				hi = 0.9891765099647811
			},
			new NumberPair
			{
				lo = 1.3417793949041587E-16,
				hi = 0.9852776423889411
			},
			new NumberPair
			{
				lo = 1.8546939997825006E-17,
				hi = 0.9807852804032304
			},
			new NumberPair
			{
				lo = 8.544974638125596E-17,
				hi = 0.9757021300385285
			},
			new NumberPair
			{
				lo = -9.265700211408681E-17,
				hi = 0.9700312531945441
			},
			new NumberPair
			{
				lo = -8.455835190129563E-17,
				hi = 0.96377606579544
			},
			new NumberPair
			{
				lo = -1.8149073506315562E-16,
				hi = 0.956940335732209
			},
			new NumberPair
			{
				lo = 2.1449018973222698E-16,
				hi = 0.9495281805930365
			},
			new NumberPair
			{
				lo = 8.312592291481732E-17,
				hi = 0.9415440651830207
			},
			new NumberPair
			{
				lo = 4.2041415555384355E-17,
				hi = 0.9329927988347388
			},
			new NumberPair
			{
				lo = -2.0439955784069464E-16,
				hi = 0.923879532511287
			},
			new NumberPair
			{
				lo = 1.8572842239721687E-16,
				hi = 0.9142097557035305
			},
			new NumberPair
			{
				lo = -1.1763205693126407E-16,
				hi = 0.9039892931234434
			},
			new NumberPair
			{
				lo = 1.0690617854732477E-16,
				hi = 0.8932243011955152
			},
			new NumberPair
			{
				lo = 9.117905405662509E-17,
				hi = 0.8819212643483549
			},
			new NumberPair
			{
				lo = 1.8015609405648135E-16,
				hi = 0.8700869911087112
			},
			new NumberPair
			{
				lo = 1.738611569886947E-16,
				hi = 0.8577286100002719
			},
			new NumberPair
			{
				lo = -4.363136029687964E-17,
				hi = 0.8448535652497071
			},
			new NumberPair
			{
				lo = -1.0961491676404285E-16,
				hi = 0.8314696123025453
			},
			new NumberPair
			{
				lo = 2.0716145511260453E-16,
				hi = 0.8175848131515835
			},
			new NumberPair
			{
				lo = 7.796169265770074E-17,
				hi = 0.8032075314806448
			},
			new NumberPair
			{
				lo = -7.662530930845594E-17,
				hi = 0.7883464276266063
			},
			new NumberPair
			{
				lo = 7.845639542886589E-17,
				hi = 0.7730104533627369
			},
			new NumberPair
			{
				lo = 2.021355061476958E-16,
				hi = 0.7572088465064843
			},
			new NumberPair
			{
				lo = -1.25730919414813E-16,
				hi = 0.7409511253549592
			},
			new NumberPair
			{
				lo = -1.928461335906283E-16,
				hi = 0.7242470829514671
			},
			new NumberPair
			{
				lo = 6.268583589525109E-17,
				hi = 0.7071067811865475
			},
			new NumberPair
			{
				lo = -1.2691162575732245E-16,
				hi = 0.689540544737067
			},
			new NumberPair
			{
				lo = -4.048903774929669E-17,
				hi = 0.6715589548470184
			},
			new NumberPair
			{
				lo = 1.1959186666851827E-16,
				hi = 0.6531728429537766
			},
			new NumberPair
			{
				lo = -2.1162370299575128E-16,
				hi = 0.6343932841636457
			},
			new NumberPair
			{
				lo = 1.372537202297826E-16,
				hi = 0.6152315905806267
			},
			new NumberPair
			{
				lo = 9.758366052593619E-17,
				hi = 0.5956993044924332
			},
			new NumberPair
			{
				lo = -1.489317979214584E-16,
				hi = 0.5758081914178454
			},
			new NumberPair
			{
				lo = 4.709410940561677E-17,
				hi = 0.5555702330196022
			},
			new NumberPair
			{
				lo = -1.6470543517087378E-16,
				hi = 0.5349976198870974
			},
			new NumberPair
			{
				lo = 1.7633189740141568E-16,
				hi = 0.5141027441932216
			},
			new NumberPair
			{
				lo = 1.0999651929485943E-16,
				hi = 0.4928981922297839
			},
			new NumberPair
			{
				lo = -4.8994473095188815E-17,
				hi = 0.4713967368259977
			},
			new NumberPair
			{
				lo = -1.0613911003931213E-16,
				hi = 0.4496113296546067
			},
			new NumberPair
			{
				lo = 9.411189816295473E-18,
				hi = 0.4275550934302821
			},
			new NumberPair
			{
				lo = -1.0111116226822567E-16,
				hi = 0.40524131400498997
			},
			new NumberPair
			{
				lo = -6.556192392771941E-17,
				hi = 0.38268343236508984
			},
			new NumberPair
			{
				lo = -7.311283835509711E-17,
				hi = 0.3598950365349882
			},
			new NumberPair
			{
				lo = 5.509114183092308E-17,
				hi = 0.33688985339222
			},
			new NumberPair
			{
				lo = 7.007159853122674E-17,
				hi = 0.3136817403988914
			},
			new NumberPair
			{
				lo = 9.20943237547414E-17,
				hi = 0.2902846772544623
			},
			new NumberPair
			{
				lo = -3.456992865243114E-17,
				hi = 0.2667127574748984
			},
			new NumberPair
			{
				lo = -3.6507007145348577E-17,
				hi = 0.24298017990326393
			},
			new NumberPair
			{
				lo = -2.812071373862042E-17,
				hi = 0.21910124015686983
			},
			new NumberPair
			{
				lo = -3.574665468409064E-17,
				hi = 0.1950903220161283
			},
			new NumberPair
			{
				lo = -4.631915321308192E-17,
				hi = 0.17096188876030127
			},
			new NumberPair
			{
				lo = -5.178420408421126E-17,
				hi = 0.1467304744553618
			},
			new NumberPair
			{
				lo = -2.492012546663238E-17,
				hi = 0.12241067519921622
			},
			new NumberPair
			{
				lo = -1.634582362244256E-18,
				hi = 0.0980171403295606
			},
			new NumberPair
			{
				lo = 2.4977081465001553E-17,
				hi = 0.0735645635996674
			},
			new NumberPair
			{
				lo = -6.79610372051828E-19,
				hi = 0.049067674327418015
			},
			new NumberPair
			{
				lo = 6.8470254137814494E-18,
				hi = 0.02454122852291228
			},
			default(NumberPair),
			new NumberPair
			{
				lo = -6.8470254137814494E-18,
				hi = -0.02454122852291228
			},
			new NumberPair
			{
				lo = 6.79610372051828E-19,
				hi = -0.049067674327418015
			},
			new NumberPair
			{
				lo = -2.4977081465001553E-17,
				hi = -0.0735645635996674
			},
			new NumberPair
			{
				lo = 1.634582362244256E-18,
				hi = -0.0980171403295606
			},
			new NumberPair
			{
				lo = 2.492012546663238E-17,
				hi = -0.12241067519921622
			},
			new NumberPair
			{
				lo = 5.178420408421126E-17,
				hi = -0.1467304744553618
			},
			new NumberPair
			{
				lo = 4.631915321308192E-17,
				hi = -0.17096188876030127
			},
			new NumberPair
			{
				lo = 3.574665468409064E-17,
				hi = -0.1950903220161283
			},
			new NumberPair
			{
				lo = 2.812071373862042E-17,
				hi = -0.21910124015686983
			},
			new NumberPair
			{
				lo = 3.6507007145348577E-17,
				hi = -0.24298017990326393
			},
			new NumberPair
			{
				lo = 3.456992865243114E-17,
				hi = -0.2667127574748984
			},
			new NumberPair
			{
				lo = -9.20943237547414E-17,
				hi = -0.2902846772544623
			},
			new NumberPair
			{
				lo = -7.007159853122674E-17,
				hi = -0.3136817403988914
			},
			new NumberPair
			{
				lo = -5.509114183092308E-17,
				hi = -0.33688985339222
			},
			new NumberPair
			{
				lo = 7.311283835509711E-17,
				hi = -0.3598950365349882
			},
			new NumberPair
			{
				lo = 6.556192392771941E-17,
				hi = -0.38268343236508984
			},
			new NumberPair
			{
				lo = 1.0111116226822567E-16,
				hi = -0.40524131400498997
			},
			new NumberPair
			{
				lo = -9.411189816295473E-18,
				hi = -0.4275550934302821
			},
			new NumberPair
			{
				lo = 1.0613911003931213E-16,
				hi = -0.4496113296546067
			},
			new NumberPair
			{
				lo = 4.8994473095188815E-17,
				hi = -0.4713967368259977
			},
			new NumberPair
			{
				lo = -1.0999651929485943E-16,
				hi = -0.4928981922297839
			},
			new NumberPair
			{
				lo = -1.7633189740141568E-16,
				hi = -0.5141027441932216
			},
			new NumberPair
			{
				lo = 1.6470543517087378E-16,
				hi = -0.5349976198870974
			},
			new NumberPair
			{
				lo = -4.709410940561677E-17,
				hi = -0.5555702330196022
			},
			new NumberPair
			{
				lo = 1.489317979214584E-16,
				hi = -0.5758081914178454
			},
			new NumberPair
			{
				lo = -9.758366052593619E-17,
				hi = -0.5956993044924332
			},
			new NumberPair
			{
				lo = -1.372537202297826E-16,
				hi = -0.6152315905806267
			},
			new NumberPair
			{
				lo = 2.1162370299575128E-16,
				hi = -0.6343932841636457
			},
			new NumberPair
			{
				lo = -1.1959186666851827E-16,
				hi = -0.6531728429537766
			},
			new NumberPair
			{
				lo = 4.048903774929669E-17,
				hi = -0.6715589548470184
			},
			new NumberPair
			{
				lo = 1.2691162575732245E-16,
				hi = -0.689540544737067
			},
			new NumberPair
			{
				lo = -6.268583589525109E-17,
				hi = -0.7071067811865475
			},
			new NumberPair
			{
				lo = 1.928461335906283E-16,
				hi = -0.7242470829514671
			},
			new NumberPair
			{
				lo = 1.25730919414813E-16,
				hi = -0.7409511253549592
			},
			new NumberPair
			{
				lo = -2.021355061476958E-16,
				hi = -0.7572088465064843
			},
			new NumberPair
			{
				lo = -7.845639542886589E-17,
				hi = -0.7730104533627369
			},
			new NumberPair
			{
				lo = 7.662530930845594E-17,
				hi = -0.7883464276266063
			},
			new NumberPair
			{
				lo = -7.796169265770074E-17,
				hi = -0.8032075314806448
			},
			new NumberPair
			{
				lo = -2.0716145511260453E-16,
				hi = -0.8175848131515835
			},
			new NumberPair
			{
				lo = 1.0961491676404285E-16,
				hi = -0.8314696123025453
			},
			new NumberPair
			{
				lo = 4.363136029687964E-17,
				hi = -0.8448535652497071
			},
			new NumberPair
			{
				lo = -1.738611569886947E-16,
				hi = -0.8577286100002719
			},
			new NumberPair
			{
				lo = -1.8015609405648135E-16,
				hi = -0.8700869911087112
			},
			new NumberPair
			{
				lo = -9.117905405662509E-17,
				hi = -0.8819212643483549
			},
			new NumberPair
			{
				lo = -1.0690617854732477E-16,
				hi = -0.8932243011955152
			},
			new NumberPair
			{
				lo = 1.1763205693126407E-16,
				hi = -0.9039892931234434
			},
			new NumberPair
			{
				lo = -1.8572842239721687E-16,
				hi = -0.9142097557035305
			},
			new NumberPair
			{
				lo = 2.0439955784069464E-16,
				hi = -0.923879532511287
			},
			new NumberPair
			{
				lo = -4.2041415555384355E-17,
				hi = -0.9329927988347388
			},
			new NumberPair
			{
				lo = -8.312592291481732E-17,
				hi = -0.9415440651830207
			},
			new NumberPair
			{
				lo = -2.1449018973222698E-16,
				hi = -0.9495281805930365
			},
			new NumberPair
			{
				lo = 1.8149073506315562E-16,
				hi = -0.956940335732209
			},
			new NumberPair
			{
				lo = 8.455835190129563E-17,
				hi = -0.96377606579544
			},
			new NumberPair
			{
				lo = 9.265700211408681E-17,
				hi = -0.9700312531945441
			},
			new NumberPair
			{
				lo = -8.544974638125596E-17,
				hi = -0.9757021300385285
			},
			new NumberPair
			{
				lo = -1.8546939997825006E-17,
				hi = -0.9807852804032304
			},
			new NumberPair
			{
				lo = -1.3417793949041587E-16,
				hi = -0.9852776423889411
			},
			new NumberPair
			{
				lo = 1.5200961239956277E-16,
				hi = -0.9891765099647811
			},
			new NumberPair
			{
				lo = 7.992924736708675E-17,
				hi = -0.9924795345987101
			},
			new NumberPair
			{
				lo = -1.795576912467269E-16,
				hi = -0.9951847266721967
			},
			new NumberPair
			{
				lo = 2.1287983538792114E-16,
				hi = -0.9972904566786904
			},
			new NumberPair
			{
				lo = -2.0975291158795585E-16,
				hi = -0.9987954562051722
			},
			new NumberPair
			{
				lo = -8.11708160587159E-17,
				hi = -0.9996988186962041
			},
			new NumberPair
			{
				lo = 0.0,
				hi = -1.0
			},
			new NumberPair
			{
				lo = -8.11708160587159E-17,
				hi = -0.9996988186962041
			},
			new NumberPair
			{
				lo = -2.0975291158795585E-16,
				hi = -0.9987954562051722
			},
			new NumberPair
			{
				lo = 2.1287983538792114E-16,
				hi = -0.9972904566786904
			},
			new NumberPair
			{
				lo = -1.795576912467269E-16,
				hi = -0.9951847266721967
			},
			new NumberPair
			{
				lo = 7.992924736708675E-17,
				hi = -0.9924795345987101
			},
			new NumberPair
			{
				lo = 1.5200961239956277E-16,
				hi = -0.9891765099647811
			},
			new NumberPair
			{
				lo = -1.3417793949041587E-16,
				hi = -0.9852776423889411
			},
			new NumberPair
			{
				lo = -1.8546939997825006E-17,
				hi = -0.9807852804032304
			},
			new NumberPair
			{
				lo = -8.544974638125596E-17,
				hi = -0.9757021300385285
			},
			new NumberPair
			{
				lo = 9.265700211408681E-17,
				hi = -0.9700312531945441
			},
			new NumberPair
			{
				lo = 8.455835190129563E-17,
				hi = -0.96377606579544
			},
			new NumberPair
			{
				lo = 1.8149073506315562E-16,
				hi = -0.956940335732209
			},
			new NumberPair
			{
				lo = -2.1449018973222698E-16,
				hi = -0.9495281805930365
			},
			new NumberPair
			{
				lo = -8.312592291481732E-17,
				hi = -0.9415440651830207
			},
			new NumberPair
			{
				lo = -4.2041415555384355E-17,
				hi = -0.9329927988347388
			},
			new NumberPair
			{
				lo = 2.0439955784069464E-16,
				hi = -0.923879532511287
			},
			new NumberPair
			{
				lo = -1.8572842239721687E-16,
				hi = -0.9142097557035305
			},
			new NumberPair
			{
				lo = 1.1763205693126407E-16,
				hi = -0.9039892931234434
			},
			new NumberPair
			{
				lo = -1.0690617854732477E-16,
				hi = -0.8932243011955152
			},
			new NumberPair
			{
				lo = -9.117905405662509E-17,
				hi = -0.8819212643483549
			},
			new NumberPair
			{
				lo = -1.8015609405648135E-16,
				hi = -0.8700869911087112
			},
			new NumberPair
			{
				lo = -1.738611569886947E-16,
				hi = -0.8577286100002719
			},
			new NumberPair
			{
				lo = 4.363136029687964E-17,
				hi = -0.8448535652497071
			},
			new NumberPair
			{
				lo = 1.0961491676404285E-16,
				hi = -0.8314696123025453
			},
			new NumberPair
			{
				lo = -2.0716145511260453E-16,
				hi = -0.8175848131515835
			},
			new NumberPair
			{
				lo = -7.796169265770074E-17,
				hi = -0.8032075314806448
			},
			new NumberPair
			{
				lo = 7.662530930845594E-17,
				hi = -0.7883464276266063
			},
			new NumberPair
			{
				lo = -7.845639542886589E-17,
				hi = -0.7730104533627369
			},
			new NumberPair
			{
				lo = -2.021355061476958E-16,
				hi = -0.7572088465064843
			},
			new NumberPair
			{
				lo = 1.25730919414813E-16,
				hi = -0.7409511253549592
			},
			new NumberPair
			{
				lo = 1.928461335906283E-16,
				hi = -0.7242470829514671
			},
			new NumberPair
			{
				lo = -6.268583589525109E-17,
				hi = -0.7071067811865475
			},
			new NumberPair
			{
				lo = 1.2691162575732245E-16,
				hi = -0.689540544737067
			},
			new NumberPair
			{
				lo = 4.048903774929669E-17,
				hi = -0.6715589548470184
			},
			new NumberPair
			{
				lo = -1.1959186666851827E-16,
				hi = -0.6531728429537766
			},
			new NumberPair
			{
				lo = 2.1162370299575128E-16,
				hi = -0.6343932841636457
			},
			new NumberPair
			{
				lo = -1.372537202297826E-16,
				hi = -0.6152315905806267
			},
			new NumberPair
			{
				lo = -9.758366052593619E-17,
				hi = -0.5956993044924332
			},
			new NumberPair
			{
				lo = 1.489317979214584E-16,
				hi = -0.5758081914178454
			},
			new NumberPair
			{
				lo = -4.709410940561677E-17,
				hi = -0.5555702330196022
			},
			new NumberPair
			{
				lo = 1.6470543517087378E-16,
				hi = -0.5349976198870974
			},
			new NumberPair
			{
				lo = -1.7633189740141568E-16,
				hi = -0.5141027441932216
			},
			new NumberPair
			{
				lo = -1.0999651929485943E-16,
				hi = -0.4928981922297839
			},
			new NumberPair
			{
				lo = 4.8994473095188815E-17,
				hi = -0.4713967368259977
			},
			new NumberPair
			{
				lo = 1.0613911003931213E-16,
				hi = -0.4496113296546067
			},
			new NumberPair
			{
				lo = -9.411189816295473E-18,
				hi = -0.4275550934302821
			},
			new NumberPair
			{
				lo = 1.0111116226822567E-16,
				hi = -0.40524131400498997
			},
			new NumberPair
			{
				lo = 6.556192392771941E-17,
				hi = -0.38268343236508984
			},
			new NumberPair
			{
				lo = 7.311283835509711E-17,
				hi = -0.3598950365349882
			},
			new NumberPair
			{
				lo = -5.509114183092308E-17,
				hi = -0.33688985339222
			},
			new NumberPair
			{
				lo = -7.007159853122674E-17,
				hi = -0.3136817403988914
			},
			new NumberPair
			{
				lo = -9.20943237547414E-17,
				hi = -0.2902846772544623
			},
			new NumberPair
			{
				lo = 3.456992865243114E-17,
				hi = -0.2667127574748984
			},
			new NumberPair
			{
				lo = 3.6507007145348577E-17,
				hi = -0.24298017990326393
			},
			new NumberPair
			{
				lo = 2.812071373862042E-17,
				hi = -0.21910124015686983
			},
			new NumberPair
			{
				lo = 3.574665468409064E-17,
				hi = -0.1950903220161283
			},
			new NumberPair
			{
				lo = 4.631915321308192E-17,
				hi = -0.17096188876030127
			},
			new NumberPair
			{
				lo = 5.178420408421126E-17,
				hi = -0.1467304744553618
			},
			new NumberPair
			{
				lo = 2.492012546663238E-17,
				hi = -0.12241067519921622
			},
			new NumberPair
			{
				lo = 1.634582362244256E-18,
				hi = -0.0980171403295606
			},
			new NumberPair
			{
				lo = -2.4977081465001553E-17,
				hi = -0.0735645635996674
			},
			new NumberPair
			{
				lo = 6.79610372051828E-19,
				hi = -0.049067674327418015
			},
			new NumberPair
			{
				lo = -6.8470254137814494E-18,
				hi = -0.02454122852291228
			}
		};
		PointerIndices.Register(Pointer);
	}
}
