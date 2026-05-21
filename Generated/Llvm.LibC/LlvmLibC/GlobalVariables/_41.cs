using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_116poly_approx_f128ERKNS_6fputil11DyadicFloatILm128EEE.COEFFS_128.41")]
[DemangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_116poly_approx_f128ERKNS_6fputil11DyadicFloatILm128EEE.COEFFS_128.41")]
internal static partial class _41
{
	[FixedAddressValueType]
	private static InlineArray8_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 __value;

	public unsafe static InlineArray8_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* Pointer => unchecked((InlineArray8_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref __value));

	public static InlineArray8_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 Value
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

	unsafe static _41()
	{
		Value = new InlineArrayBuilder<InlineArray8_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>
		{
			new Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -127,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 0L, -9223372036854775808L })
					}
				}
			},
			new Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -128,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3899075386890062161L, -5660435428506895957L })
					}
				}
			},
			new Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -130,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8698002800084809340L, -721156499326601917L })
					}
				}
			},
			new Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -132,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7117070760484837225L, -2064822672440296359L })
					}
				}
			},
			new Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -134,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1748631367195998695L, -7091661442265138866L })
					}
				}
			},
			new Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -137,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4173178487785724553L, -5853554456092112765L })
					}
				}
			},
			new Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -140,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1202827264700627332L, -6808165567494560342L })
					}
				}
			},
			new Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -144,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 8844706467831160953L, -7320354865663587L })
					}
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
