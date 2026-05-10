using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_111LOG10_TABLEE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::LOG10_TABLE")]
internal static partial class anonymous_namespace_LOG10_TABLE
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

	unsafe static anonymous_namespace_LOG10_TABLE()
	{
		Value = new LogRR
		{
			step_1 = new InlineArrayBuilder<InlineArray128_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>
			{
				default(fputil_DyadicFloat_kt2kd4),
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -136,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7327138133984587731L, -2361189418708101013L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6270262442219969611L, -2297609491694052330L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7759727508394989104L, -6286701570994897229L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -275098998730049778L, -2168410945903000347L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2555201688093445246L, -8231758774397997068L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8739940250131375309L, -6138994392479969196L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6846397501141086365L, -4029005418683294805L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6434009661544630556L, -1901505962783614133L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2458681333885538379L, -831098507355597602L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7539267975169610185L, -8561762795734929911L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1206002577215417161L, -7475475730309060646L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2088567974682568965L, -6928860375027782459L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3573186588839162755L, -5828586610197485347L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7196364653047256426L, -4718786547078481318L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8441866938506789801L, -4160262323245440399L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3257342583543878140L, -3035859441659085208L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1525588473326830814L, -2469937522111206763L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2170491338111093340L, -1330542405973204586L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4097220975820662280L, -757024193871488723L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4309329012497938125L, -9024487856624910817L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4999928731337511590L, -8733827252853682739L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8653769815686488090L, -8148521328441592310L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3492052974530585011L, -7853851598865559192L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7801533355392516067L, -7260416310138104765L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8167362532755187578L, -6961625310777097335L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7630102271194793548L, -6359831656578320734L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 299000980934934858L, -6056802471333079089L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5134942764757998873L, -5752333712109893730L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -584716749151236076L, -5139022301876462228L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8268672461941768429L, -4830151567770379524L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -869823015393966683L, -4519785085778483839L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6903311298234627935L, -3894506435610674082L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6351533073379647761L, -3579564508085344966L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7129231607595468971L, -3263067305476343945L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5196480180649272889L, -2944999390715553091L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5546799967892412124L, -2625345095754378065L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8893933440935404435L, -1981213510230045796L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 580629217355816180L, -1656703686399367885L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2170491338111093340L, -1330542405973204586L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3587900352192466341L, -1002712774144977857L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6749603024058838989L, -673197635517554755L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2009265536585453733L, -9040880862225492L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1777285923139059147L, -9060553837805168141L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6068628431003892800L, -8892336776245715779L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4379459703757458576L, -8723232021597904202L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2807725214117196289L, -8553230155301507997L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7453211816306684895L, -8382321608097920596L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7904968108513180611L, -8210496656797979100L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3656963374588289066L, -8037745420962667238L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5318819424978915796L, -7864057859493863165L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7005388790614776903L, -7689423767132190752L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3776704809323996531L, -7513832770858920164L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 370016780292715486L, -7337274326198745770L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8726413003626887542L, -7159737713420146369L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4046186919612503862L, -6981212033629904250L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6073864841470784153L, -6801686204758225339L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4722200508421303986L, -6621148957430762361L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5006188935482097794L, -6439588830723696301L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7927708836901367301L, -6256994167797878083L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -9112035915771839630L, -6073353111407871987L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6553810674038492238L, -5888653599281574577L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6406991247509600032L, -5702883359365907314L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5431184556569200804L, -5516029904933897307L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7043524570163052770L, -5328080529548268259L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7043524570163052770L, -5328080529548268259L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -584716749151236076L, -5139022301876462228L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4149676084662434373L, -4948842060351801797L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6639257725847439797L, -4757526407675281153L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -12625230950654887L, -4565061705152242850L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5718774902893293147L, -4371434066857954116L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5718774902893293147L, -4371434066857954116L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6002512851265011442L, -4176629353625841831L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4857426447349714178L, -3980633166851878085L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1779481917490429530L, -3783430842108327897L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 164510572023754557L, -3585007442559776407L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8956196622721911745L, -3385347752174043964L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8956196622721911745L, -3385347752174043964L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6412953669550105901L, -3184436268720273113L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7730919399607541520L, -2982257196546130723L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1811185670624997280L, -2778794439125710388L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1811185670624997280L, -2778794439125710388L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8511097643137666980L, -2574031591369343860L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2590212110767186126L, -2367951931686134510L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -148119917473063445L, -2160538413789609544L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -148119917473063445L, -2160538413789609544L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4456288417410040834L, -1951773658236449787L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5660968175664225007L, -1741639943687794902L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5660968175664225007L, -1741639943687794902L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8472363443890369946L, -1530119197882136652L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1768767215653479195L, -1317192988308301779L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1768767215653479195L, -1317192988308301779L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3982783443653600676L, -1102842512566487641L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8072633232079828741L, -887048588404746361L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8072633232079828741L, -887048588404746361L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 9142759136091956004L, -669791643417715039L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1300045815643634656L, -451051704393758736L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1300045815643634656L, -451051704393758736L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1160472061342654751L, -230808386296027397L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2009265536585453733L, -9040880862225492L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2009265536585453733L, -9040880862225492L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2254770737974148026L, -9116236009258351612L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8176383306161319769L, -9003795980660416822L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8176383306161319769L, -9003795980660416822L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7317193045649814230L, -8890561316293698276L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7317193045649814230L, -8890561316293698276L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1900943884883375253L, -8776520704474754411L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8204392758582802007L, -8661662590254011368L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8204392758582802007L, -8661662590254011368L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6061645940218954476L, -8545975168389875860L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6061645940218954476L, -8545975168389875860L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3274527205871909964L, -8429446376067354607L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2343036018252532519L, -8312063885349949499L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2343036018252532519L, -8312063885349949499L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4357849150894968604L, -8193815095353017462L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4357849150894968604L, -8193815095353017462L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2695357779571194147L, -8074687124126169252L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2695357779571194147L, -8074687124126169252L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 253329661354531884L, -7954666800231629880L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 253329661354531884L, -7954666800231629880L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6217961184967363478L, -7833740654004792428L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6217961184967363478L, -7833740654004792428L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 616198289885558773L, -7711894908482464091L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 616198289885558773L, -7711894908482464091L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8943605142500534758L, -7589115469983525443L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8943605142500534758L, -7589115469983525443L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3705812007901163449L, -7465387918325897934L })
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
					exponent = -137,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 9159442045557019419L, -2392974288860906447L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7177323870009472199L, -2642357664175695482L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 383129443764951243L, -2891756202569844782L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5388545300508869369L, -3141169905887366251L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8119758669471424305L, -3390598775972608191L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 922474434281295042L, -3640042814670255390L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6580284362711809976L, -3889502023825329201L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5275790292295055403L, -4138976405283187622L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -655987086056459985L, -4388465960889525382L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3890352469230671155L, -4637970692490374018L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8711372911369290065L, -4887490601932101962L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1126069149343080682L, -5137025691061414620L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1246294451295680019L, -5386575961725354456L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4372150875354037509L, -5636141415771301069L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8739763112264808715L, -5885722055046971282L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2774766298161929948L, -6135317881400419220L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1144665723056811085L, -6384928896680036394L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1644107064242476683L, -6634555102734551779L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1509703021823016480L, -6884196501413031902L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -716881237964336490L, -7196269617206066269L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1322960586737697163L, -7445945206050865496L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 9120778591609525621L, -7695635993531427865L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4672678893835582893L, -7945341981498255402L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7308174201834063034L, -8195063171802188115L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4621488717690847212L, -8444799566294404077L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8936277535345587910L, -8694551166826419504L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8196456358139920844L, -8944317975250088842L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1108701391364296846L, -9194099993417604847L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5494997460879417896L, -441050372653445715L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 881716338445754532L, -940675259079728230L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5126366956592953449L, -1440330576110921985L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6880397397635106835L, -1940016327454120621L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4461495035297138155L, -2439732516817095227L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5055927353600797815L, -2939479147908294501L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6811097925952445964L, -3439256224436844917L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2066178590576001062L, -3939063750112550890L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 42275637742174914L, -4438901728645894939L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5386365852890154254L, -4938770163748037858L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8063005282619044355L, -5438669059130818874L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4948036743306841529L, -5938598418506755817L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7367029938912698363L, -6438558245589045284L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6884241351743084882L, -6938548544091562806L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2576729948592313563L, -7438569317728863011L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5275918264044287518L, -7938620570216179792L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2372234482772246255L, -8438702305269426471L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4648563549946268484L, -8938814526605195964L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6228266154765677231L, -431170402171970283L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6664091692577988158L, -1431516812278596450L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5043147218574729153L, -2431924217257984207L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6816613663682047207L, -3432392624548759465L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5338005177482838398L, -4432922041590908985L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8828180968098372493L, -5433512475825780708L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6423174217874276650L, -6434163934696084087L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2435859126880958973L, -7434876425645890421L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 855840097194611412L, -8435649956120633186L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7588604514545686448L, -426224993424665119L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7155351637435972242L, -2428016257157397969L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -299514180015629384L, -4429929644628957311L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7282951984586619243L, -6431965170741114162L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8272994171830977468L, -8434122850398367222L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8833236474892848191L, -2426061323306335454L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5502623311974706291L, -6430865386250046700L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2913319427866647292L, -2425083617777824451L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1199703468515322402L, -2424594705343711601L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = 0,
					mantissa = default(BigInt_qdkjbh)
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1348149801813262881L, -2423616761108455765L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3639455536767561364L, -2423127729296383398L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -141,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1061038776774675090L, -6428665011687932931L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -141,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8475633939097074727L, -2422149546256018317L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4365246894659607842L, -8431066774526575492L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6642377107486008294L, -6427564421395566684L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8193929010798642241L, -4423939735652475697L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2376363983231120948L, -2420192702357283332L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 765900943671259514L, -416323306567233373L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8802551539854730516L, -8429537803523191766L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4688773003194230152L, -7427480720713699157L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6064183768918268170L, -6425362434234429024L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3612385453104867602L, -5423182936608525876L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6320685131188952857L, -4420942220357764041L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1377751028460661819L, -3418640278002547328L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3882992999150561802L, -2416277102061908696L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8157104134492057952L, -1413852685053509916L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8409202518812023253L, -411367019493641237L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7800411292378166708L, -8927782085803386334L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -165057522598314162L, -8426477993243673588L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3260758243759227646L, -7925143265178545023L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1682437626056916737L, -7423777897863401045L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4749338299937896945L, -6922381887552955458L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6780613020739281584L, -6420955230501235299L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8749417195804829746L, -5919497922961580669L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7934678764639489896L, -5418009961186644567L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4757697233694195860L, -4916491341428392720L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8062421293645595385L, -4414942059938103415L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7537764351172683775L, -3913362112966367333L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2596955023790343201L, -3411751496763087378L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2959430083699562218L, -2910110207577478510L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6544653903361644688L, -2408438241658067577L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4046013165867637979L, -1906735595252693148L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7894569051539243291L, -1405002264608505340L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -453081801660967502L, -903238245971965656L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -841822080002019288L, -401443535588846810L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6598166586009475233L, -9173181101706892090L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1269846683580126133L, -8922253049136034586L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1835210373362910899L, -8671309645058479373L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1035683134402795989L, -8420350887595734396L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4321721770974517776L, -8169376774868962783L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -215039527257655066L, -7918387304998982764L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 311854700957856424L, -7667382476106267583L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3480178456146479114L, -7416362286310945422L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2403798894540745977L, -7165326733732799304L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4161632509898687468L, -6977039986341698773L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -855882670789917968L, -6725977544368300186L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6996739114238130012L, -6474899734439700583L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1036213307829251499L, -6223806554674387918L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7602413842937093372L, -5972698003190504590L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6875395372786586106L, -5721574078105847358L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 190993718904835112L, -5470434777537867259L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4047507144140284931L, -5219280099603669523L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7697122238689062400L, -4968110042420013486L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5002724577276672352L, -4716924604103312507L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8326549570166100056L, -4465723782769633884L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7557361227156885958L, -4214507576534698767L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3403543292527487505L, -3963275983513882075L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4271814326087805237L, -3712029001822212411L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5178486896951313971L, -3460766629574371976L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4033679279568034952L, -3209488864884696485L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -41576325148023315L, -2958195705867175083L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7918408650338389620L, -2706887150635450256L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2736444836484271656L, -2455563197302817753L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5486954415169422660L, -2204223843982226494L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -988438445985070246L, -1952869088786278490L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7491095783756021845L, -1701498929827228754L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -567208068369283550L, -1450113365216985221L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5913289581109926451L, -1198712393067108656L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2707816918273936843L, -947296011488812576L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4119630243984793589L, -695864218592963159L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1993784991696932723L, -444417012490079164L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7254754199407634798L, -192954391290331842L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1651476738683555934L, -9194110213406548234L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 946466406814719124L, -9068363484874372894L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3020737448587923416L, -8942609045957979821L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7422251308411977235L, -8816846895711759200L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5123966241643436116L, -8691077033189927249L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5262284530360968499L, -8596744574548637162L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5504894956260577127L, -8470961213268169751L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1613960989983906870L, -8345170137110288249L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6555808029260267061L, -8219371345128556122L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8333178713974576762L, -8093564836376362663L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2126904378943515054L, -7967750609906922955L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8198230190492287742L, -7841928664773277827L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4861606909989413578L, -7716099000028293808L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -728144955715156272L, -7590261614724663088L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4493400660151877666L, -7464416507914903473L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5853606478510702921L, -7338563678651358344L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2673082723951790473L, -7212703125986196612L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4167713427099747236L, -7086834848971412678L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8685651271007452531L, -6960958846658826387L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 646432208384711596L, -6835075118100082986L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -538162882011788153L, -6709183662346653085L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5658428247911787684L, -6583284478449832606L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7662651077873390207L, -6457377565460742749L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -704450276421426012L, -6331462922430329944L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -22561142333733656L, -6205540548409365808L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6237302674117186517L, -6079610442448447104L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6297358309605423136L, -5953672603597995698L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7369963574146904837L, -5827727030908258514L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5405056186069568657L, -5733262775487489817L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8404588151516588502L, -5607303666293132842L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7432103952779928615L, -5481336820646766743L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3387464817409827996L, -5355362237597982034L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4799636913508504057L, -5229379916196194085L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1577146753092054118L, -5103389855490643076L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7532448286098487021L, -4977392054530393957L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4420562619293582279L, -4851386512364336405L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7522250461917322525L, -4725373228041184778L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8630765754123451726L, -4599352200609478075L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7418644360988060933L, -4473323429117579891L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8876672650636413018L, -4347286912613678375L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3260103845983565246L, -4221242650145786186L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 467262891780838118L, -4095190640761740449L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4424575944884993550L, -3969130883509202717L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4454794046247913200L, -3843063377435658919L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 559292865135626816L, -3716988121588419324L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1131604475122820357L, -3590905115014618497L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 428368860747303311L, -3464814356761215252L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5459295621787086746L, -3370241200458010755L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6449068075778039577L, -3244136874471519153L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4333010149387055318L, -3118024794183655317L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3131221720476952740L, -2991904958640718619L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1457114613988645392L, -2865777366888832477L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5330120113472088849L, -2739642017973944312L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3187682321660494795L, -2613498910941825504L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4875563159770828587L, -2487348044838071348L })
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
					exponent = -143,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6113606363228274835L, -8432786123218318211L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4386017916602682724L, -8557958240003949507L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -9059307922898295634L, -8683130416474063164L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2155722187015775425L, -8808302652628716100L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 925671220598366928L, -8933474948467965233L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5691275619610644339L, -9058647303991867481L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6307906325751614440L, -9183819719200479760L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8168204026954967207L, -171240314478166362L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1173707522741693069L, -421585383634572556L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5137921171391608839L, -671930572160740320L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7753612980616490071L, -922275880056783492L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2766796970441199481L, -1172621307322815907L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1713802671441679203L, -1422966853958951402L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5319633797350136003L, -1673312519965303814L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5641856763476079650L, -1923658305341986978L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 229550535941369378L, -2174004210089114732L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3588910602298771089L, -2424350234206800914L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 9150242971669717875L, -2674696377695159359L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4933329324370087996L, -2925042640554303906L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 9868582635763902L, -3175389022784348391L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6961532971662072935L, -3425735524385406654L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4452566602351253525L, -3676082145357592531L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7481090100588522060L, -3926428885701019860L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7333108842956319256L, -4176775745415802480L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7486737118115774989L, -4427122724502054229L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1125439743490065491L, -4677469822959888946L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6318727917419738425L, -4927817040789420468L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3702772008967562722L, -5178164377990762636L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6071089385010965928L, -5428511834564029287L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3889576294593615906L, -5678859410509334262L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2331627883090516907L, -5929207105826791399L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2100635171155010272L, -6179554920516514537L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2241044775311353374L, -6429902854578617518L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6884598856920324661L, -6680250908013214179L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6625369227902974875L, -6930599080820418362L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8090883414223466707L, -7180947373000343906L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2729347346936635649L, -7431295784553104652L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1237848486507441784L, -7681644315478814439L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7414678973429987426L, -7931992965777587110L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6022822940504994381L, -8182341735449536504L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6626775266618972032L, -8432690624494776462L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8150023578913531411L, -8683039632913420826L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 192346174228193989L, -8933388760705583436L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5408452662572639096L, -9183738007871378135L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6608837706444400804L, -421430675112285911L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5719055288577956037L, -922129646939086711L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1688575002355586122L, -1422828857513834738L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2746431367811772720L, -1923528306836757675L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1158307698848478158L, -2424227994908083209L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8738313228579809418L, -2924927921728039022L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6770955295242242491L, -3425628087296852801L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -667776461655460814L, -3926328491614752231L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5728935330839242832L, -4427029134681964997L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5399141775322672795L, -4927730016498718786L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7578018234328027483L, -5428431137065241284L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7726623025884293338L, -5929132496381760178L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7314205880096659781L, -6429834094448503155L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4628524674975769303L, -6930535931265697902L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3830842367423263893L, -7431238006833572108L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3154032489868232428L, -7931940321152353459L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 81019272294410535L, -8432642874222269645L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7666772557567208300L, -8933345666043548355L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4535499266878313536L, -421353319523282937L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 842587341261812402L, -1422759858172656583L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6035952070468881439L, -2424166874326121413L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7130885233096436967L, -3425574367984132805L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3581408103996482710L, -4426982339147146140L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1661169179640078580L, -5428390787815616800L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5992213595940014539L, -6429799713990000167L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4994932103608958591L, -7431209117670751623L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6480244170499211138L, -8432618998858326552L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1034498934470757622L, -421314641396809057L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6391264022686696505L, -2424136313801985110L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6956947741627436005L, -4426958941223540415L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3584686493183123687L, -6429782523662385744L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5447240801654555351L, -8432607061119431871L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1854990103839519429L, -2424121033481627523L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8082766107818834733L, -6429773928473987616L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 440464718454766636L, -2424113393306876298L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8658540080377338801L, -2424109573215857569L })
						}
					}
				},
				default(fputil_DyadicFloat_kt2kd4),
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -150,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6215193984893754723L, -2424101933026533863L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -9217477609239663230L, -2424098112928228881L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -148,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -102280764473098013L, -6429756738048009262L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -148,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4690762183126562604L, -2424090472724332647L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1907148552409415247L, -8432583185527795224L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7505402742430535599L, -6429748142810428930L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 909416530313935509L, -4426912145063932459L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8891314111883572463L, -2424075192287395023L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3767532041337807050L, -421237284479905829L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7673190322464758332L, -8432571247675052851L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2618409967956332687L, -7431151338738990307L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7211229023196482107L, -6429730952286085694L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7843822239967501268L, -5428310088315883613L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2925618161251423794L, -4426888746827928665L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2883322042481091777L, -3425466927821765451L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6732549374573229016L, -2424044631296938571L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8539331354394724857L, -1422621857252992623L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2943916781675369953L, -421198605689472206L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -958119960655322482L, -8933259475157736768L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4657341205517940649L, -8432547371855718987L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3969601985420754821L, -7931835029793230867L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7633247375281821921L, -7431122448970044707L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4947137230600311829L, -6930409629385932804L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2150054376387288416L, -6429696571040667455L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1685485863385794506L, -5928983273934020957L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3192095005716753163L, -5428269738065765606L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6790246740386538020L, -4927555963435673700L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -9021428876775897472L, -4426841950043517534L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1024299034189360997L, -3926127697889069404L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6222103053776538201L, -3425413206972101604L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5832934097297668674L, -2924698477292386431L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5608943440337406136L, -2423983508849696178L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2878786121959018947L, -1923268301643803141L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5073187835312782630L, -1422552855674479612L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1943932788711328518L, -921837170941497887L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6010165161906868491L, -421121247444630257L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4451145477416107758L, -9183574579446600317L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2361597763967774829L, -8933216378933939038L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3636252910906276247L, -8682858059038993246L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8957255073209332084L, -8432499619761649087L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2444463838895100701L, -8182141061101792707L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -997786404227716857L, -7931782383059310253L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7494015821333328595L, -7681423585634087868L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2362145281486880990L, -7431064668826011699L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2053144016590475757L, -7180705632634967892L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6853845314846557874L, -6930346477060842590L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8309294773815499671L, -6679987202103521939L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6996938372246873259L, -6429627807762892084L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7967524989252412259L, -6179268294038839169L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2133157786881462573L, -5928908660931249339L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5979996003657308084L, -5678548908440008737L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3596443713264346122L, -5428189036565003509L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7513912127975916972L, -5177829045306119797L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6905018969129789572L, -4927468934663243746L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2068868801194910751L, -4677108704636261499L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3502007747868714124L, -4426748355225059200L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6258797722725490987L, -4176387886429522992L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8398166233826220551L, -3926027298249539018L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7463131959077039135L, -3675666590684993421L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -363532818775338240L, -3425305763735772344L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -123865815628425985L, -3174944817401761929L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3333116245647493559L, -2924583751682848318L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4642510735819705199L, -2674222566578917655L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1444015005830796912L, -2423861262089856081L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5618067882205413324L, -2173499838215549739L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5551920649715265103L, -1923138294955884769L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4714024131672444208L, -1672776632310747314L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1526397145405834997L, -1422414850280023515L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8651822907946728038L, -1172052948863599514L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4864230855263138381L, -921690928061361451L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8835678668175924545L, -671328787873195468L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5349381708612159011L, -420966528298987705L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 639950971839024477L, -170604149338624303L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7250044664918191734L, -9183492862350771510L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4690031907402915524L, -9058311553484263381L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2822430284780734679L, -8933130184924506643L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1743974561348864130L, -8807948756671444366L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -49059393723651855L, -8682767268725019620L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5170263534753035617L, -8557585721085175474L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -122455694095291550L, -8432404113751855000L })
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
					exponent = -151,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1985621054854537042L, -2173753999565548124L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5805540422993569948L, -2424107663169437424L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1997266236333386599L, -2674461327705966578L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8061349651352713882L, -2924814993175135592L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4604855109645328824L, -3175168659576944474L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -9128336632758286396L, -3425522326911393230L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2238861527353734403L, -3675875995178481868L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1436986680047141288L, -3926229664378210394L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5776526336278662636L, -4176583334510578815L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4135447899686837483L, -4426937005575587138L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7648369230078441295L, -4677290677573235371L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3288308121198395668L, -4927644350503523520L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -284932822959901320L, -5177998024366451592L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2307935256525372192L, -5428351699162019593L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5436473276611388477L, -5678705374890227532L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8399887109591828652L, -5929059051551075415L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1361483460380010060L, -6179412729144563249L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 9051113012288027665L, -6429766407670691040L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5337329663919015719L, -6680120087129458796L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6890080564904314961L, -6930473767520866524L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3791209794318311895L, -7180827448844914231L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7313630208426515158L, -7431181131101601923L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2731014978342034363L, -7681534814290929608L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7543943911230719608L, -7931888498412897292L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2359510099373898061L, -8182242183467504983L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4678296215006601764L, -8432595869454752687L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4892601784520617481L, -8682949556374640411L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8852598361903460302L, -8933303244227168163L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8147850621012513262L, -9183656933012335949L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7449028466367351781L, -421277171750735936L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6942513125563721315L, -921984553051631687L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6539873847525718288L, -1422691936217807548L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7897495025764770029L, -1923399321249263533L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -9123076777887000646L, -2424106708145999656L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8324322086568121774L, -2924814096908015931L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3608936799553475262L, -3425521487535312372L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6915370370341924127L, -3926228880027888992L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6694143771523794413L, -4426936274385745806L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2380331038962353063L, -4927643670608882828L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 30972704568743663L, -5428351068697300070L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2626409244686600356L, -5929058468650997549L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8460199924892404825L, -6429765870469975276L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2868618834426933097L, -6930473274154233266L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3641169882451610357L, -7431180679703771534L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7650553635192418557L, -7931888087118590092L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7267266922239483639L, -8432595496398688955L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -599047107106897574L, -8933302907544068137L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8400756984176892968L, -421276567399903685L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4535479805742003034L, -1422691397151783406L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4501636090674494333L, -2424106230634223848L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4717785776969255589L, -3425521067847225039L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -891545101210158236L, -4426935908790787006L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1318104936371059658L, -5428350753464909776L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5695649497762425600L, -6429765601869593379L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2421176058898467283L, -7431180454004837842L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -801153958195890783L, -8432595309870643192L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8213120604548546920L, -421276265224467297L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1340878374290289262L, -2424105991878321713L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2264886104728856597L, -4426935725993298072L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6985231594386467391L, -6429765467569396427L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -233366573782731893L, -8432595216606616836L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4189884212380492704L, -2424105872500367088L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6184561484059735992L, -6429765400419296450L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -156,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4416532072128288976L, -2424105812811388886L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = new anon_izyfb7
					{
						val = 1
					},
					exponent = -157,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7298742586906296307L, -2424105782966899563L })
						}
					}
				},
				default(fputil_DyadicFloat_kt2kd4),
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -157,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 953857741174027458L, -2424105723277920471L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -156,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2475034495715327120L, -2424105693433430703L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -155,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1694619653511351636L, -6429765266119093494L })
						}
					}
				},
				new fputil_DyadicFloat_kt2kd4
				{
					sign = default(anon_izyfb7),
					exponent = -155,
					mantissa = new BigInt_qdkjbh
					{
						val = new cpp_array_i3937k
						{
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 307255788642106845L, -2424105633744450722L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4419376654110463612L, -8432595030078557175L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1993723783707471131L, -6429765198968990516L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -138166073063277185L, -4426935360398301137L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6421444640486179634L, -2424105514366488982L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8481199003419807852L, -421275660873553996L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -9169592780105867373L, -8432594936814523870L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1108792350142646010L, -7431180002606933463L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6191909079306741700L, -6429765064668781556L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8948169599801953084L, -5428350123000068123L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3375653033045662872L, -4426935177600793135L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4136773004593200207L, -3425520228470956565L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7447204796433530797L, -2424105275610558385L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8924114653010657704L, -1422690319019598567L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6578733619664887777L, -421275358698077083L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6638976969730053284L, -8933302234177772761L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5528749782385990331L, -8432594750286450312L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7435845369598265836L, -7931887264529846988L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -974454960481829289L, -7431179776907962776L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6483464932249395420L, -6930472287420797661L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7408270649622640096L, -6429764796068351630L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5641008685960812476L, -5929057302850624669L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3073812749551140695L, -5428349807767616764L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1598813683608789182L, -4927642310819327901L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3108139466276815957L, -4426934812005758066L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8952828863083421673L, -3926227311326907245L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4201519090945896658L, -3425519808782775425L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7569814563872150368L, -2924812304373362591L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3044174073549544930L, -2424104798098668730L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7483288727240034053L, -1923397289958693827L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3673718977077511921L, -1422689779953437869L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2081752827035322505L, -921982268082900842L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 815285219548795966L, -421274754347082732L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8214479017917652361L, -9183655656227767571L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 5068591900528049838L, -8933301897494577412L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8470677100141607113L, -8682948137828746691L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -972056255588452991L, -8432594377230275401L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5758909459053473709L, -8182240615699163534L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6835926443817997841L, -7931886853235411084L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5149149710910194788L, -7681533089839018044L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1644620328821839204L, -7431179325509984407L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2731622066491710348L, -7180825560248310165L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7033539271611532744L, -6930471794053995313L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8131649558054385972L, -6680118026927039843L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6816491613432924774L, -6429764258867443748L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8413764874043116010L, -6179410489875207021L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4577242260551634033L, -5929056719950329655L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5682989397804191612L, -5678702949092811644L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3247001309891337930L, -5428349177302652980L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7507565725082617890L, -5177995404579853656L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -963965312795133019L, -4927641630924413666L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3008969457328458519L, -4677287856336333002L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3858142036973584543L, -4426934080815611657L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 244602650884744118L, -4176580304362249625L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 3651135445134564984L, -3926226526976246899L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5315023234429796368L, -3675872748657603472L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -9153147462005343928L, -3425518969406319336L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8809253952961875667L, -3175165189222394485L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -5229357990132410572L, -2924811408105828912L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 640526576186832698L, -2674457626056622609L })
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
							Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7854387328236457158L, -2424103843074775571L })
						}
					}
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
