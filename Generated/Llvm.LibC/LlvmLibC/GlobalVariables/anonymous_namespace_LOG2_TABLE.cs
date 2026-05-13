using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_110LOG2_TABLEE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::LOG2_TABLE")]
internal static partial class anonymous_namespace_LOG2_TABLE
{
	[FixedAddressValueType]
	private static LogRR __value;

	public unsafe static LogRR* Pointer => unchecked((LogRR*)Unsafe.AsPointer(ref __value));

	public static LogRR Value
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

	unsafe static anonymous_namespace_LOG2_TABLE()
	{
		Value = new LogRR
		{
			step_1 = new InlineArrayBuilder<InlineArray128_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>
			{
				default(fputil_DyadicFloat_kt2kd4),
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1674686625602632342L, -5087980091135673638L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -133,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6621688949224013104L, -5035178104680959566L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -132,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2235685945655133789L, -8348047367511490231L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -132,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3322539353599556288L, -4927881034910487825L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -132,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6139516653520285148L, -1480020746387328990L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -131,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3553703972299498243L, -8225379210980169626L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -131,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5798837427404706828L, -6473071297990737808L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -131,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2726771493443262500L, -4706221244388056263L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -131,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2511806614676510414L, -3817267094597251217L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -131,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2793959175592751611L, -2028145561339811888L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -131,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7667755623038283963L, -223861800464341175L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -130,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2611803642354027774L, -8881348710635517603L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -130,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7937707348542200956L, -7967591127771203946L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -130,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2474231698234417297L, -7045922125425507061L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -130,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4202925053794409178L, -6582077797718972971L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -130,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4519364695360394753L, -5648281417140467627L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -130,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3576795175039189605L, -5178293436125796880L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -130,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6114746381088939747L, -4232046274256727245L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -130,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5879071468188100409L, -3755749708829162451L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -130,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -916055508713648008L, -2796715251329258394L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -130,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -9124584190674800587L, -2313938438456975305L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -130,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3145488210540819485L, -1341766341252704270L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -130,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2333695201061440915L, -852330514556961297L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1380494131746615339L, -9156699954602925331L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6091133778453003593L, -8908559400783724703L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6306162170095850455L, -8408780588981763183L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7492824852595129571L, -8157120297972514386L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2375680317183654248L, -7904264466652765592L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1318366057227443652L, -7394920365510409427L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6511798386829767531L, -7138408773181539335L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5644129855679649940L, -6880654989121481613L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2829060088817905366L, -6361372310340058169L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -911480483726630604L, -6099818701013965596L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7740710627973143925L, -5836973463688941023L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2378013272065819536L, -5572823778157413543L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7872450526183574322L, -5307356632386678757L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8510981594479617219L, -4772416929697273457L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3060998956104103344L, -4502917354484754095L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6114746381088939747L, -4232046274256727245L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8586698852988147781L, -3959789658180035589L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5106976818888306060L, -3686133259005750407L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4617918136452602786L, -3134563013331062592L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8868134970049974620L, -2856619549405446232L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1385390593064324560L, -2577217057988575361L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1573009181958562677L, -2296340140266775589L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5853164168851358152L, -2013973152350133820L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8171832903696096506L, -1730100200044143852L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6508443726466352202L, -1444705133481179618L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3613321786133336773L, -1157771541607262130L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2699109413974578512L, -869282746519414153L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5493879893477047582L, -579221797648717094L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -129,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4847632789082862283L, -287571465783997242L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3601983317225278232L, -9220529155320212200L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7261491523334097110L, -9073088189855120185L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8648777035797825530L, -8924825822016602613L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5077891944173849951L, -8775732848344909874L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1412577395624562998L, -8625799909827227963L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 362427339212794177L, -8475017488372349945L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8370146196918141614L, -8323375903184909094L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 318300113065536272L, -8170865307035720186L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1203460007990960794L, -8017475682424636078L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5889551584099973815L, -7863196837632180881L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7941722583815829625L, -7708018402656068487L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1079915725753759753L, -7551929825028555382L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1079915725753759753L, -7551929825028555382L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1318366057227443652L, -7394920365510409427L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3831413545473321448L, -7236979093657101011L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2768989040560657340L, -7078094883252639379L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4983189198381309386L, -6918256407606284491L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4633266920959774268L, -6757452134707163026L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4633266920959774268L, -6757452134707163026L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3839368245652951309L, -6595670322231605599L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8510757512090084051L, -6432899012397800341L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 9210907800804346043L, -6269126026662125183L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4432554130142442223L, -6104338960251276792L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2643573386881494323L, -5938525176524057594L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2643573386881494323L, -5938525176524057594L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3761331883580549187L, -5771671801156412887L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4957814856363874414L, -5603765716143027047L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5614007629001224668L, -5434793553608490429L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5614007629001224668L, -5434793553608490429L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1649776039612579567L, -5264741689420736010L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3588836181888369031L, -5093596236599116107L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2720572083942358790L, -4921343038509143853L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2720572083942358790L, -4921343038509143853L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -894429023817348710L, -4747967661835560381L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5887103353441119205L, -4573455389325005896L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5887103353441119205L, -4573455389325005896L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7789069856384022555L, -4397791212289169808L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1627266194865485768L, -4220959822858870674L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1627266194865485768L, -4220959822858870674L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4261758524580788546L, -4042945605979069570L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4450234279948162710L, -3863732631134349280L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4450234279948162710L, -3863732631134349280L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 748414122318168480L, -3683304643793894918L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6608718204244939233L, -3501645056564487676L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6608718204244939233L, -3501645056564487676L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 9207057831265119150L, -3318736940039470676L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4617918136452602786L, -3134563013331062592L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4617918136452602786L, -3134563013331062592L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8201761669028259805L, -2949105634272778851L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6636756727736349541L, -2762346789278069823L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6636756727736349541L, -2762346789278069823L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5235541152651980469L, -2574268082840598206L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5235541152651980469L, -2574268082840598206L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5726572810036647291L, -2384850726660851501L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4776672290136783638L, -2194075528383017501L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4776672290136783638L, -2194075528383017501L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5564858261641185159L, -2001922879925238372L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5564858261641185159L, -2001922879925238372L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8228720067234472737L, -1808372745385499311L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3723489112635254076L, -1613404648504497789L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3723489112635254076L, -1613404648504497789L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -347078554705622695L, -1416997659665875673L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -347078554705622695L, -1416997659665875673L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3497965704259211161L, -1219130382413175476L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3497965704259211161L, -1219130382413175476L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8970102776596272172L, -1019780939461799803L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8970102776596272172L, -1019780939461799803L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7276840307841268592L, -818926958183105433L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7276840307841268592L, -818926958183105433L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4565943597582276230L, -616545555536546167L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4565943597582276230L, -616545555536546167L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7238981678587003310L, -412613322424486499L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7238981678587003310L, -412613322424486499L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -128,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1024861384528500600L, -207106307442936368L })
						}
					}
				},
				default(fputil_DyadicFloat_kt2kd4)
			},
			step_2 = new InlineArrayBuilder<InlineArray193_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>
			{
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5345793269588654966L, -5114376854423911423L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -22752461713176304L, -5321485264637920725L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5931832492673347288L, -5528606267516762994L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -540965502192648811L, -5735739864591856969L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -300549593227305405L, -5942886057394900760L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3409046010947266370L, -6150044847457871922L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3780769034275567283L, -6357216236313027523L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8884814725223802200L, -6564400225492904208L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4387172653753535978L, -6771596816530318269L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8120268072196180355L, -6978806010958365715L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4855370334568146142L, -7186027810310422337L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6896093594036606404L, -7393262216120143777L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1696546652624966435L, -7600509229921465598L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 30391286556252231L, -7807768853248603350L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8077758875615889922L, -8015041087636052639L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3794507196638422755L, -8222325934618589194L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6202737960558007734L, -8429623395731268936L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -120628571104926173L, -8636933472509428049L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2429456790852628694L, -8844256166488683041L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6053031921807790837L, -9103427279241662513L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8772719159956953689L, -174812661369315548L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4911184778186289380L, -589540082352430455L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3669047889005512973L, -1004292750796735468L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4685470662152411120L, -1419070669776409299L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7538191016784576177L, -1833873842366192169L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 139371458964587037L, -2248702271641385949L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2149085148027845529L, -2663555960677854295L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1034616746469049086L, -3078434912552022780L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6288499032554097889L, -3493339130340879041L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7838424793849917330L, -3908268617121972906L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1839483880749285249L, -4323223375973416537L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4727581906166340665L, -4738203409973884563L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3141422241574201335L, -5153208722202614223L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5287790047764010864L, -5568239315739405495L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6957223551064822848L, -5983295193664621240L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5134131459508168562L, -6398376359059187336L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7459698824569476621L, -6813482815004592815L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 701773675495303334L, -7228614564582890002L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6238675079361642085L, -7643771610876694652L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6553942457602601630L, -8058953956969186084L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5563860095821259543L, -8474161605944107323L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8618731084718830755L, -8889394560885765236L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1042206606355705059L, -162561576048509718L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3183105784937819545L, -993128728309125542L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1598483958410560355L, -1823746511015824756L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8627507899904801226L, -2654414930341734577L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2348719353778390411L, -3485133992461111276L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7203988626272871821L, -4315903703549340461L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5749439292444698326L, -5146724069782937347L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2797419553839335690L, -5977595097339547035L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4224931083342543200L, -6808516792397944787L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1127134264025983989L, -7639489161138036299L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8144620176154970329L, -8470512209740857980L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -138,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7104305192583986225L, -156427815067602839L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -138,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7193679069429270259L, -1818676668819433788L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -138,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1271001975838595203L, -3481026919396517591L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -138,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6208602173580092500L, -5143478579169978281L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -138,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3299305228645246103L, -6806031660513204072L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -138,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 994671750072156314L, -8468686175801847918L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -139,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2502507484522441616L, -1816140201118104506L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -139,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8682881230627884263L, -5141855041749105552L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -139,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8999764135180252204L, -8467772824552048318L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -140,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5120792407633924417L, -5141043074883183702L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -141,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6437884892068803811L, -5140637041895478892L })
						}
					}
				},
				default(fputil_DyadicFloat_kt2kd4),
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -141,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -9049794746700943882L, -5139824876787896517L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -140,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1518218450258967056L, -5139418744658942299L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -139,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7168036945908228661L, -8465945453032758016L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -139,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5260736571313870891L, -5138606381228009524L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -139,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8327612655899187504L, -1811064168968798337L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -138,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1604129137609760054L, -8465031432579465084L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -138,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8336747990476797095L, -6801057148784506003L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -138,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3782263525303379163L, -5136981257546880357L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -138,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4009941207986450534L, -3472803746456897723L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -138,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 546261855840330564L, -1808524603102594077L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -138,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2069866231028193510L, -144143815069731240L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4894974786738881092L, -8463202721825673969L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5422057333086716680L, -7630910664504776389L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4588654797736207431L, -6798567766216416698L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6139085272951705872L, -5966174020748924715L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4859270401671416020L, -5133729421889491793L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5499153144709551286L, -4301233963424170536L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5275077615122228412L, -3468687639137874527L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8090597117930564357L, -2636090442814378043L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3045995217781713737L, -1803442368236315782L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7244526379156496902L, -970743409185182582L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1438616016382782523L, -137993559441333141L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3430070532700440630L, -8875968443246766679L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4075786147575828254L, -8459542618350376793L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3498152317271471721L, -8043091338774739026L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7456088398027945891L, -7626614601407749057L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8122977414817606083L, -7210112403136731797L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3637398014652699670L, -6793584740848441253L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8590081286904722225L, -6377031611429060384L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7725477239807364136L, -5960453011764200966L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7031448054087632694L, -5543848938738903448L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1306451652782745140L, -5127219389237636816L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1555147133768502832L, -4710564360144298449L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 9148836927761600336L, -4293883848342213983L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3145872598613372274L, -3877177850714137170L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5373176650083337825L, -3460446364142249738L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2115631615250017278L, -3043689385508161248L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6705090607562682569L, -2626906911692908961L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3357737478643862033L, -2210098939576957690L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7503986890742571505L, -1793265466040199665L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7825723942533076676L, -1376406487961954392L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8879445531215620446L, -959522002220968512L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2463654199946999429L, -542612005695415661L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2229636310272036628L, -125676495262896329L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6217295234778552969L, -9077729770754994669L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3290179541489779418L, -8921361011741630511L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -375476776319866699L, -8712858166851015280L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 968898949685184839L, -8504342559149864242L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5649292801159892876L, -8295814187075615467L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1273191046137558163L, -8087273049065420045L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5978565984460919602L, -7878719143556142019L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2745697109435365616L, -7670152468984358317L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2535347802135536029L, -7461573023786358680L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -889081889361456132L, -7252980806398145591L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3897126219536125126L, -7044375815255434203L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2167709342201168832L, -6835758048793652273L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1608156705701744646L, -6627127505447940090L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -821882149174523313L, -6418484183653150403L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8501484795626741489L, -6209828081843848349L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5788585538840221691L, -6001159198454311389L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4254642362040459080L, -5792477531918529231L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3712749391154566124L, -5583783080670203762L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -527997708795865791L, -5375075843142748980L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3768772357761725541L, -5166355817769290916L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4797985620639510841L, -4957623002982667574L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4890347110549542027L, -4748877397215428850L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5279366227342576538L, -4540118998899836468L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1398815239409493685L, -4331347806467863908L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 692207501755852080L, -4122563818351196334L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 829159124045355167L, -3913767032981230524L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6979814121197915877L, -3704957448789074800L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6041261568379222610L, -3496135064205548955L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4376208363383567645L, -3287299877661184185L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4890516549498564388L, -3078451887586223018L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7595175155771694906L, -2869591092410619241L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2631726163397542955L, -2660717490564037831L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2709210406010120902L, -2451831080475854882L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 955408177656676181L, -2242931860575157539L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -512310934568706373L, -2086249038265006699L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6843430030804905662L, -1877327397411530736L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3683128203694111874L, -1668392942424039534L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8062515613859096392L, -1459445671730536034L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5860169822353671418L, -1250485583758733887L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2156874196378232000L, -1041512676936057385L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7327641914070042586L, -832526949689641388L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7778766053625244831L, -623528400446331255L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2122089534382735755L, -414517027632682771L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -135,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5037385731777041407L, -205492829674962078L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6144023952744796217L, -9221599939354348608L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1625336200181855385L, -9117075012870235797L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6573450353053877905L, -9012543671452616803L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5798931943555564694L, -8908005914314045054L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7690540199250397299L, -8803461740666928976L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2204669507001898724L, -8698911149723531960L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2223511557544558251L, -8594354140695972324L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6931677413252036709L, -8489790712796223283L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6334976997735145949L, -8385220865236112906L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3219144924280815656L, -8280644597227324086L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7118159145022856405L, -8176061907981394500L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 340990054591331205L, -8071472796709716578L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3204491853653519238L, -7966877262623537465L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6671176912553862833L, -7888426396612320627L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5968135665799369179L, -7783819620702390749L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -9186605883183356733L, -7679206419808139907L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2077445278914403047L, -7574586793140270107L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1941680540154344154L, -7469960739909337902L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1731705370161284224L, -7365328259325754354L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3152023674594814202L, -7260689350599784996L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8325512332944980467L, -7156044012941549804L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8435164628532617606L, -7051392245561023152L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2416042505775497735L, -6946734047668033783L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1991471056768593828L, -6842069418472264768L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6312689192074012211L, -6737398357183253477L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -350734847741868691L, -6632720863010391535L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6434611781448202229L, -6528036935162924791L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5858239505529199357L, -6423346572849953284L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7468587012006671152L, -6318649775280431201L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5613115702350902383L, -6213946541663166847L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7525460264117766397L, -6109236871206822606L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2444480758129669722L, -6004520763119914906L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2609107027360002046L, -5925979456883467690L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2992252554062883503L, -5821252081038127454L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6068276882731229068L, -5716518265384891055L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 912763913443406542L, -5611778009131727266L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2046221684966987563L, -5507031311486458734L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6062858554320976167L, -5402278171656761942L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3403523462876277740L, -5297518588850167173L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -134,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5296868851571681652L, -5192752562274058479L })
						}
					}
				}
			},
			step_3 = new InlineArrayBuilder<InlineArray161_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>
			{
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2806523478942403771L, -1813919945330802322L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5428806116971561105L, -2021826331054157622L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7241073621784596732L, -2229732815911292315L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7356360794711340423L, -2437639399902300939L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1117551755005917661L, -2645546083027278032L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5368609083856356634L, -2853452865286318131L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7465364567202280985L, -3061359746679515776L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1958656788902992620L, -3269266727206965505L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4364042591828399294L, -3477173806868761855L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4133895780586815002L, -3685080985664999367L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5174226778103164821L, -3892988263595772578L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2579917292546580941L, -4100895640661176027L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -475978068128705259L, -4308803116861304255L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 452417910758682645L, -4516710692196251798L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -781955708656176701L, -4724618366666113199L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5625931816414121383L, -4932526140270982994L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8539710003964710951L, -5140434013010955725L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5671653537128830048L, -5348341984886125931L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2206374355969994272L, -5556250055896588151L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4893320873967788116L, -5764158226042436927L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7254446327368927462L, -5972066495323766797L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3406795721927302664L, -6179974863740672303L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7641228108399613527L, -6387883331293247984L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2845533550120510575L, -6595791897981588381L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3040309727312559252L, -6803700563805788036L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3547024674338426078L, -7011609328765941488L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2135673169732194779L, -7219518192862143278L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6123385298232799870L, -7427427156094487949L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4390148791489685737L, -7635336218463070040L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8555673081047672907L, -7843245379967984094L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2795394478331992845L, -8051154640609324652L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4432876310829742117L, -8259064000387186255L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7931927804631067449L, -8466973459301663445L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -800508097543740742L, -8674883017352850765L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5562523514408462956L, -8882792674540842755L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5378750395399224346L, -9090702430865733959L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4362528193859229218L, -150480498945686221L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5983201803475629007L, -566300408143632737L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4745799829998633184L, -982120515615944934L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 172346234188183304L, -1397940821362811897L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4120694185212688572L, -1813761325384422714L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1387084274106679760L, -2229582027680966468L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6175362900419430947L, -2645402928252632248L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 671580755653802329L, -3061224027099609138L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7524462798547729717L, -3477045324222086227L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5009759493029614574L, -3892866819620252601L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5973496413486492889L, -4308688513294297347L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6292255715649546976L, -4724510405244409553L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3434419906412157279L, -5140332495470778307L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 142000162756301891L, -5556154783973592696L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3010644221011930692L, -5971977270753041811L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6882905075118534154L, -6387799955809314738L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7991752761633122264L, -6803622839142600567L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 749965817309310835L, -7219445920753088387L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -674329014100344991L, -7635269200640967289L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8216375641833529872L, -8051092678806426360L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8483148123021530799L, -8466916355249654692L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5355903638706644593L, -8882740229970841375L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4688948951916439361L, -150384532230799381L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4647582370958106172L, -982033074786140694L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5836550170510476580L, -1813682013898533253L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5580667459191755237L, -2645331349568355241L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5636444220297650320L, -3476981081795984842L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2722881201933166104L, -4308631210581800240L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8083768247120161656L, -5140281735926179618L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -9012237587796934747L, -5971932657829501162L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4392853909927469649L, -6803583976292143057L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4840438069176343426L, -7635235691314483490L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8570044192047112515L, -8466887802896900646L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -145,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6167054583219092565L, -150336548369993810L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -145,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7936910989653098897L, -1813642357777404141L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -145,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2095358262950434325L, -3476948960307237046L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -145,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7090130213360040111L, -5140256355960248901L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -145,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2166900247790433007L, -6803564544737196085L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -145,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3516170931613756759L, -8466873526638834979L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -146,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 992450667641816352L, -1813622529622292306L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -146,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 866745657598153096L, -5140243665928875214L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -146,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1083071622549904049L, -8466866388489379831L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -147,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3112724975350715984L, -5140237320901086229L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -148,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1113243912704581728L, -5140234148384166193L })
						}
					}
				},
				default(fputil_DyadicFloat_kt2kd4),
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -148,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7547205785693837999L, -5140227803344275023L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -147,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1813532640024811355L, -5140224630821303885L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -146,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4277444946901076561L, -8466852112149624686L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -146,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3795847006978733324L, -5140218285769310493L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -146,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8120319803813903988L, -1813582873122972389L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -145,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 632725119960977633L, -8466844973959324602L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -145,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3582872608022060663L, -6803525681367862460L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -145,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1279006297961560269L, -5140205595641119182L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -145,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1040887915493964847L, -3476884716778338370L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -145,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8602940826054321649L, -1813563044778763630L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -145,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2534162146577903297L, -150240579641638562L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1184228008673053042L, -8466830697537879192L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5353213428063542233L, -7635168671830631732L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6607708714729465163L, -6803506249553474508L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7761517535721362554L, -5971843430706029319L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3161850803894077692L, -5140180215287917963L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2863910212605947479L, -4308516603298762239L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3991805145482457338L, -3476852594738183942L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7323456256724949031L, -2645188189605804871L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2541687870086609035L, -1813523387901246821L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7245131132266810005L, -981858189624131587L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -144,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2478543038356190952L, -150192594774080965L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5236931427266339694L, -8882635338530134183L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2630133550342091206L, -8466802144531606176L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7947324822249382184L, -8050968752246043165L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -533244994245669514L, -7635135161673256048L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2109804461757566994L, -7219301372813055720L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7484764403128534976L, -6803467385665253077L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1937803598720100895L, -6387633200229659016L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -235332533041367939L, -5971798816506084431L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7615660256229050597L, -5555964234494340217L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2402908528555798219L, -5140129454194237270L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5175550209240630182L, -4724294475605586483L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8564153572058427101L, -4308459298728198752L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6975400677016978949L, -3892623923561884970L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3761538109481648276L, -3476788350106456031L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7635637333110280514L, -3060952578361722828L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3873740679296961417L, -2645116608327496255L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8791660023797004246L, -2229280440003587204L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -275111104055640349L, -1813444073389806569L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1379184108166833325L, -1397607508485965241L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3271145950975254655L, -981770745291874112L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1988827410105326937L, -565933783807344076L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 9060019641757941719L, -150096624032186022L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3079906833679484597L, -9090501669837881230L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5724245305123621029L, -8882582891659390523L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7968726095728354358L, -8674664014335302144L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3474303041342074100L, -8466745037865521539L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5244471950679335320L, -8258825962249954152L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3068791626307800075L, -8050906787488505428L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5924520274185999979L, -7842987513581080813L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8723699810258050064L, -7635068140527585751L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 915785896496673995L, -7427148668327925686L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7107803053672092399L, -7219229096982006064L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2460425189702834315L, -7011309426489732328L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6653698611962895238L, -6803389656851009922L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1810520317495856937L, -6595469788065744291L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4452037735450084795L, -6387549820133840878L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8289332327180487429L, -6179629753055205127L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6436188076440955959L, -5971709586829742482L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -600132140593090786L, -5763789321457358387L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -913033223779623557L, -5555868956937958284L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1452597365846675743L, -5347948493271447616L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4947138439261713096L, -5140027930457731828L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7930504234768473989L, -4932107268496716362L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3154083124650933098L, -4724186507388306660L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7243618554088463769L, -4516265647132408166L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5677150526142744755L, -4308344687728926322L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6234698478740908928L, -4100423629177766570L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 546307015292029530L, -3892502471478834352L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6310246210082861839L, -3684581214632035112L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8391677825244320426L, -3476659858637274290L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3236742466459664353L, -3268738403494457329L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4335624976293565303L, -3060816849203489670L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4236447496586369970L, -2852895195764276755L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7007991217450271837L, -2644973443176724025L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4946732409439575685L, -2437051591440736922L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4517638376314448956L, -2229129640556220887L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4707165006836804258L, -2021207590523081361L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -142,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6997110614966427617L, -1813285441341223785L })
						}
					}
				}
			},
			step_4 = new InlineArrayBuilder<InlineArray130_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>
			{
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1217097913552991674L, -4932318344929014896L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4709880904904196711L, -5140232562124949788L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8389652927174004318L, -5348146780095425313L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8027978775264224242L, -5556060998840441477L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 603575566229471030L, -5763975218359998285L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3286698849307976926L, -5971889438654095744L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4249822709987842291L, -6179803659722733859L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7721377594591700048L, -6387717881565912636L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -516951313961302149L, -6595632104183632081L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2210008124973135205L, -6803546327575892198L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1683938714926239276L, -7011460551742692995L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2133266143444802010L, -7219374776684034477L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7786414908381610789L, -7427289002399916650L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4425064244185879087L, -7635203228890339519L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3722363730677668023L, -7843117456155303091L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6019295986271188399L, -8051031684194807370L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 984974986689936970L, -8258945913008852363L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3849835893670627952L, -8466860142597438076L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 395551993192097447L, -8674774372960564514L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5149460544751395488L, -8882688604098231684L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8556786739859738181L, -9090602836010439590L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7250718470655587467L, -150290063684824861L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2536196331392272521L, -566118530607403656L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1124006916008818802L, -981946999079063959L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1497363086143096705L, -1397775469099805781L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4662012334987847967L, -1813603940669629136L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7301426578577622937L, -2229432413788534033L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8951004984301589365L, -2645260888456520485L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8743533807676658077L, -3061089364673588503L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3310922478902727653L, -3476917842439738099L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -308813635011668652L, -3892746321754969284L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7759920052966948241L, -4308574802619282069L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7541408154448033673L, -4724403285032676467L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -862511081288318322L, -5140231768995152489L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -640080225812605250L, -5556060254506710146L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1582678681750684622L, -5971888741567349449L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4184186541925281303L, -6387717230177070412L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8962857687862872090L, -6803545720335873044L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5859633718408617522L, -7219374212043757358L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3301387861104720811L, -7635202705300723365L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6647633558891934818L, -8051031200106771076L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4449277612399866999L, -8466859696461900504L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8758144386487791044L, -8882688194366111659L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1227114861828080165L, -150289313929257491L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7125011802459058320L, -981946315934006781L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4145977496471108590L, -1813603321036919596L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6749318413192407305L, -2645260329237995959L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5044922160590312259L, -3476917340537235893L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4123526524259766963L, -4308574354934639420L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4172045836737386402L, -5140231372430206565L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5428621987997689853L, -5971888393023937349L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5501189823572532324L, -6803545416715831797L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1601229557426229226L, -7635202443505889931L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2851482479449157614L, -8466859473394111774L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -152,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3123645007483486705L, -150288939051443082L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -152,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1468999319923488887L, -1813603011220541743L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -152,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5008457086295796619L, -3476917089585967962L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -152,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4428207837048203033L, -5140231174147721784L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -152,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3338278399963085678L, -6803545264905803256L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -152,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2910797040731013876L, -8466859361860212423L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -153,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5288205814966156935L, -1813602856312347046L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -153,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2072981766008179509L, -5140231075006476439L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -153,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3153658239385315274L, -8466859306093261501L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -154,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3843749505235556843L, -5140231025435853028L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -155,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7772138200665665732L, -5140231000650541138L })
						}
					}
				},
				default(fputil_DyadicFloat_kt2kd4),
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -155,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3268276345045837995L, -5140230951079916988L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -154,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5163936135764751618L, -5140230926294604729L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -153,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4063861166957110836L, -8466859194559357164L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -153,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2504659119631890303L, -5140230876723979840L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -153,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4810137083890236318L, -1813602546495946110L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -152,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4730431973527827996L, -8466859138792403749L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -152,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1359235305085188376L, -6803544961285730338L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -152,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5293999039613833422L, -5140230777582728586L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -152,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8306202590551397197L, -3476916587683398446L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -152,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 518810332669618360L, -1813602391587739871L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -152,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2057749049920091372L, -150288189295752817L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6484584966268569822L, -8466859027258494426L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5350993959063595645L, -7635201919916172349L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3905263417108037933L, -6803544809475685962L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4370812767770780608L, -5971887695937035243L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2420971469060455171L, -5140230579300220169L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3510033977119776706L, -4308573459565240715L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5250468988178872076L, -3476916336732096860L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4333722278474902261L, -2645259210800788580L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2293187321147133367L, -1813602081771315852L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 662262348116097187L, -981944949643678653L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 974350350083662124L, -150287814417876960L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2381429538266552045L, -8882687374901731183L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6780600517864588715L, -8466858804190665808L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5228024710504317102L, -8051030231930518151L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7713785165954474979L, -7635201658121288201L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5781223239665094082L, -7219373082762975946L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -9026317333522912815L, -6803544505855581375L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8272002291958613217L, -6387715927399104476L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -412483142019225911L, -5971887347393545238L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6095590989309017717L, -5556058765838903648L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2795573354430909141L, -5140230182735179696L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -322436341148150235L, -4724401598082373371L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6731663987468334762L, -4308573011880484659L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2945509342851114698L, -3892744424129513551L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -917105414718157918L, -3476915834829460034L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4360240921227642705L, -3061087243980324096L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4429897193737960366L, -2645258651582105727L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -9164766689044260690L, -2229430057634804915L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7986890292165666481L, -1813601462138421648L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -493098948700664300L, -1397772865092955915L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4859984387667715978L, -981944266498407703L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -384260857352142649L, -566115666354777003L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6235708804950857244L, -150287064662063801L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1352115598463780542L, -9090601267564909852L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 876779265300290087L, -8882686965169470732L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -659475339546022214L, -8674772661999490346L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8257560322039823765L, -8466858358054968685L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4952839027377078804L, -8258944053335905745L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3644802890899927448L, -8051029747842301520L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 105151143028850883L, -7843115441574156004L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8552328277589747897L, -7635201134531469192L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6311291830685297763L, -7427286826714241077L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7600488675533184426L, -7219372518122471654L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8191622801337459383L, -7011458208756160917L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3856399386998111033L, -6803543898615308860L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8813268874820634014L, -6595629587699915478L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 387194749387392085L, -6387715276009980764L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7203370167604157679L, -6179800963545504714L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 260028135239449604L, -5971886650306487320L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 102356711588601121L, -5763972336292928578L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6542071952228830558L, -5556058021504828482L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3095856709777370640L, -5348143705942187026L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -149,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3853773569457222541L, -5140229389605004203L })
						}
					}
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
