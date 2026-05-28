using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const._ZN19__llvm_libc_20_1_2_7generic11sincos_evalERKNS_6fputil11DyadicFloatILm128EEERS3_S6_.COS_COEFFS")]
[DemangledName("__const._ZN19__llvm_libc_20_1_2_7generic11sincos_evalERKNS_6fputil11DyadicFloatILm128EEERS3_S6_.COS_COEFFS")]
internal static partial class COS_COEFFS
{
	[FixedAddressValueType]
	private static InlineArray7_Fputil_DyadicFloat_kt2kd4 __value;

	public unsafe static InlineArray7_Fputil_DyadicFloat_kt2kd4* Pointer => unchecked((InlineArray7_Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref __value));

	public static InlineArray7_Fputil_DyadicFloat_kt2kd4 Value
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

	unsafe static COS_COEFFS()
	{
		Value = new InlineArrayBuilder<InlineArray7_Fputil_DyadicFloat_kt2kd4, Fputil_DyadicFloat_kt2kd4>
		{
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -127,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 0L, -9223372036854775808L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = new Anon_izyfb7
				{
					Val = 1
				},
				Exponent = -128,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 0L, -9223372036854775808L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -132,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6148914691236517205L, -6148914691236517206L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = new Anon_izyfb7
				{
					Val = 1
				},
				Exponent = -137,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6968769983401386166L, -5329059399071648245L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -143,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 58561092297490640L, -3455104445551947763L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = new Anon_izyfb7
				{
					Val = 1
				},
				Exponent = -149,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8650124011142672987L, -7786022560353033321L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -156,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 2798076594529394528L, -8109074727424442966L })
					}
				}
			}
		};
		_ = Pointer;
	}
}
