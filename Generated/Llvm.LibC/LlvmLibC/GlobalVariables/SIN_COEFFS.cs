using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const._ZN19__llvm_libc_20_1_2_7generic11sincos_evalERKNS_6fputil11DyadicFloatILm128EEERS3_S6_.SIN_COEFFS")]
[DemangledName("__const._ZN19__llvm_libc_20_1_2_7generic11sincos_evalERKNS_6fputil11DyadicFloatILm128EEERS3_S6_.SIN_COEFFS")]
internal static partial class SIN_COEFFS
{
	[FixedAddressValueType]
	private static InlineArray7_fputil_DyadicFloat_kt2kd4 __value;

	public unsafe static InlineArray7_fputil_DyadicFloat_kt2kd4* Pointer => unchecked((InlineArray7_fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref __value));

	public static InlineArray7_fputil_DyadicFloat_kt2kd4 Value
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

	unsafe static SIN_COEFFS()
	{
		Value = new InlineArrayBuilder<InlineArray7_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>
		{
			new fputil_DyadicFloat_kt2kd4
			{
				sign = default(anon_izyfb7),
				exponent = -127,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 0L, -9223372036854775808L })
					}
				}
			},
			new fputil_DyadicFloat_kt2kd4
			{
				sign = new anon_izyfb7
				{
					val = 1
				},
				exponent = -130,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6148914691236517205L, -6148914691236517206L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8608480567731124087L, -8608480567731124088L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 58561092297490640L, -3455104445551947763L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6200968995500953330L, -5120842182013903747L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4197114891794091792L, -2940240054281888641L })
					}
				}
			},
			new fputil_DyadicFloat_kt2kd4
			{
				sign = default(anon_izyfb7),
				exponent = -160,
				mantissa = new BigInt_qdkjbh
				{
					val = new cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2024806264520058526L, -5723458724435571739L })
					}
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
