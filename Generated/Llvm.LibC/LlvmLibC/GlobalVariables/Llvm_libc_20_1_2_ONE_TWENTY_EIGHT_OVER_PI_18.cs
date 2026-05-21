using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L24ONE_TWENTY_EIGHT_OVER_PIE.18")]
[DemangledName("__llvm_libc_20_1_2_::ONE_TWENTY_EIGHT_OVER_PI (.18)")]
internal static partial class Llvm_libc_20_1_2_ONE_TWENTY_EIGHT_OVER_PI_18
{
	[FixedAddressValueType]
	private static InlineArray64_InlineArray4_Double __value;

	public unsafe static InlineArray64_InlineArray4_Double* Pointer => unchecked((InlineArray64_InlineArray4_Double*)Unsafe.AsPointer(ref __value));

	public static InlineArray64_InlineArray4_Double Value
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

	unsafe static Llvm_libc_20_1_2_ONE_TWENTY_EIGHT_OVER_PI_18()
	{
		Value = new InlineArrayBuilder<InlineArray64_InlineArray4_Double, InlineArray4_Double>
		{
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 32.00000000000014, 2.642030351030676E-15, 5.175047756616543E-31, -1.3722985865315694E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 32.00000000948637, 3.0472351252000854E-15, 4.849405004284789E-31, 3.7527343382551514E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 32.00062169899644, 1.2670707094270964E-14, -5.675134633306804E-31, 1.1317102884207171E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 40.743665431525216, -9.624297972024358E-15, -2.5038171000840656E-30, -2.9622547724501325E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -31.14227956410241, -3.41621506273634E-15, -7.782978971163955E-31, 1.5604802682596271E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 19.566486984267456, 6.945686518727014E-15, 1.2151461705391607E-30, 8.729342377719622E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 5.291000952468028, 1.0715949794663455E-15, 3.1105039330186277E-31, 6.084005626616146E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -0.9615790552223036, -2.1907138246478996E-16, 4.392361471658168E-32, -5.690469068686208E-48 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -42.04496304890179, -4.098858858448074E-15, 8.134318196456917E-31, -1.8518937501796503E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -2.698372828111454, -3.565363076395804E-16, 1.71249534205928E-32, -1.5151698832292564E-48 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 55.438336887722755, -3.3183056754460725E-15, 5.407401476908646E-31, -1.563071163317445E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 54.84627379827808, -1.3981894012711528E-14, 2.314456540642793E-30, -2.5140170279512226E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 37.39964395111065, -1.4939808373787285E-15, -3.732865196409636E-31, 7.986222594444654E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -48.934020012715024, 3.2608292894282406E-15, 4.490415238339448E-31, 1.0752420564422926E-48 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -27.935553291598836, -1.1248952385249948E-15, -7.076328843927631E-32, 8.025001669886938E-48 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -0.42051822140734396, -1.0507081442234206E-16, 2.2479218187774234E-32, 1.6795458024992116E-48 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -39.08215815170075, -7.867211824837853E-15, 2.7613158220063374E-30, -6.318649690722102E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -8.31662986106575, -1.574230329440634E-15, 1.1319240195483914E-31, 4.3468454342564876E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -14.6545748050425, 2.046362145164603E-15, -2.7069818605407995E-31, 8.40081300191524E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -18.214423265174034, 2.5535981460902506E-15, -5.722846300643855E-31, -1.4485739703466177E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 27.556893554683484, 5.582975951829844E-15, 3.5736192820791425E-31, 7.239912096047844E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 16.575999737151776, -9.643731853153146E-16, 3.687728324748394E-31, -4.780893791549012E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -11.281226021300874, 1.6152730364810108E-15, 3.536567201538083E-31, -7.835130731023164E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 1.5714680260174578, 1.0058844041959779E-16, 2.037854088622264E-32, -2.953894352399725E-48 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -52.27144691987701, -1.6725565149678724E-15, -1.345701968632378E-32, 7.730387546027048E-49 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 2.454658940324844, -7.886329026312651E-16, 2.724987417591634E-32, -3.8297791012982274E-48 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -27.471686871075534, 1.0326923470996166E-15, -1.333354275178893E-31, 1.9184239502236698E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 63.529217193902156, 6.435505728523106E-15, -8.471915844649358E-31, 2.9359751922339424E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -5.221980427901393, 4.517593675490969E-16, 6.055177123704665E-32, 2.1596757312585618E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 44.290677054349146, -8.919314783356554E-15, -1.2271952810407273E-30, 5.363826954576042E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -22.188566174942665, -1.1266416512068564E-15, -3.117900977247947E-31, 8.043519215120482E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 58.1271589574597, 4.013846697049299E-15, 1.1770443529490254E-30, -2.8406996860295852E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 13.489436079079702, 1.4309320762498848E-15, 1.5097830671192804E-32, -1.0339514141574963E-48 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -52.31712143253469, -1.407657122077267E-14, -1.3578660902992933E-30, 2.0193564152794614E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -46.870202594427894, -1.0326832504567767E-14, 7.089023174242974E-31, -1.5881852417619454E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 58.40277157283697, -1.550062572938664E-15, 2.3698353769828754E-31, -1.129433046597578E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 28.037797443467127, -5.711275844343934E-15, -1.403753963091229E-31, -3.690879262445604E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 45.09325506128195, -8.68224593371412E-15, 1.6316259832009352E-30, -2.1348401171674565E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -32.43630382661797, 2.9532847997798412E-15, 1.447323483240667E-31, 2.6000566412671284E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -49.607581235274836, -5.368582679607611E-15, -8.434461140885705E-32, -5.812198152298478E-48 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -10.443834971988366, -3.0934517931785173E-15, 7.287704979949435E-31, -1.0536042876400394E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -31.168724229762034, -4.033506754762673E-16, -9.128910432715596E-32, -2.8765172263657E-48 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -49.51112168471178, -1.800097736932228E-15, -1.635988339555932E-33, 2.6417053238639923E-49 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 39.12927072855953, 7.310558016551542E-15, 6.895128892005372E-32, 1.5402091465600172E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 23.88646687801409, -2.569559851442287E-17, -8.096676192990864E-34, 1.9205592684695208E-49 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -16.50668246857991, 7.104966867821226E-15, 5.801644566438866E-31, -2.510895708150293E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -53.94226085254925, -1.7569487769573088E-15, 1.3992077142143658E-31, 2.1691594060812413E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -56.00723266799341, -7.05014410754403E-15, 1.2851358622816506E-31, -3.6983688124640617E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 37.99987038364995, 1.348597807242407E-14, -2.7680807113832867E-30, 4.833583454860071E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -8.494537116075875, 1.3716518254273739E-15, -1.1715387550769889E-31, -3.023013976954715E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -25.98443914847772, -5.292897159510175E-15, -6.020556616693162E-31, -7.673599783193307E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -4.204034636144019, 9.972113856304237E-16, 1.3605327903857505E-31, 2.709108614229162E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -59.61391433438271, 1.1735388176646568E-14, -8.959775462612314E-31, -3.7328783194974506E-48 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -41.48981810470502, -1.0576420230470147E-15, 7.700834995001415E-32, 2.0040209126103225E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 27.280690051545918, 6.9216783462247606E-15, 1.2648725305369551E-30, 3.3848421594739137E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -36.69678188628791, 8.6295889380341E-15, 1.1822406459934731E-30, 3.468860663863564E-46 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 31.70230023619463, -6.444578912663878E-16, 1.658781887700646E-31, -2.4835073157449688E-48 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -54.05172074869773, -5.321484536252873E-16, 9.527483680071663E-32, 1.043930206725317E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -61.570986654644315, -1.4435856811028467E-15, 9.763974745735073E-32, 9.915649921977047E-48 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -44.181398769935214, 9.039497058784628E-15, -3.211737879098961E-31, -2.0129543946163366E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 15.850213526409213, -2.5266954741682667E-15, -5.869135591413594E-32, -1.8659624977523438E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 39.593666754031744, -4.6354535577840654E-15, 8.907266883940766E-32, 1.847105848775058E-47 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -5.455607775902553, -9.040238447201117E-17, -5.66596291344246E-33, -5.270474793754151E-50 }),
			InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -34.71120154974642, -1.2895107233690865E-14, 1.0178017689525217E-30, 4.918779997732236E-47 })
		};
		PointerIndices.Register(Pointer);
	}
}
