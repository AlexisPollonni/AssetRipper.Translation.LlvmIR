using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_116poly_approx_f128ERKNS_6fputil11DyadicFloatILm128EEE.COEFFS_128")]
[DemangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_116poly_approx_f128ERKNS_6fputil11DyadicFloatILm128EEE.COEFFS_128")]
internal static partial class COEFFS_128
{
	[FixedAddressValueType]
	private static InlineArray7_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 __value;

	public unsafe static InlineArray7_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* Pointer => unchecked((InlineArray7_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref __value));

	public static InlineArray7_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 Value
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

	unsafe static COEFFS_128()
	{
		Value = new InlineArrayBuilder<InlineArray7_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 0L, -9223372036854775808L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6148914691236517205L, -6148914691236517206L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6148914691236517205L, -6148914691236517206L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8608480567731124087L, -8608480567731124088L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 6968769983401386166L, -5329059399071648245L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 58561092297490640L, -3455104445551947763L })
					}
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
