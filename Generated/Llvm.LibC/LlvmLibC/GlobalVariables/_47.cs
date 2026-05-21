using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_116poly_approx_f128ERKNS_6fputil11DyadicFloatILm128EEE.COEFFS_128.47")]
[DemangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_116poly_approx_f128ERKNS_6fputil11DyadicFloatILm128EEE.COEFFS_128.47")]
internal static partial class _47
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

	unsafe static _47()
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
				Exponent = -126,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1560824738470491603L, -7827944594109584362L })
					}
				}
			},
			new Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -126,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -9175630248240391205L, -6221399380099644358L })
					}
				}
			},
			new Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -126,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7660514654588540469L, -9063445257636207868L })
					}
				}
			},
			new Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -127,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -6720434917324997256L, -7643822085209972127L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -7456875781687386678L, -8496885221110861549L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8996296971381153763L, -3173146283356626069L })
					}
				}
			},
			new Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -131,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -795292435348314798L, -8398527340237855845L })
					}
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
