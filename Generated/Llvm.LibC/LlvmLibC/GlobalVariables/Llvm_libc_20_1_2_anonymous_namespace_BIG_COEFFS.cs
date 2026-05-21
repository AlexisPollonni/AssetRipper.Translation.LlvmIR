using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_110BIG_COEFFSE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::BIG_COEFFS")]
internal static partial class Llvm_libc_20_1_2_anonymous_namespace_BIG_COEFFS
{
	[FixedAddressValueType]
	private static InlineArray4_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 __value;

	public unsafe static InlineArray4_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* Pointer => unchecked((InlineArray4_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref __value));

	public static InlineArray4_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 Value
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

	unsafe static Llvm_libc_20_1_2_anonymous_namespace_BIG_COEFFS()
	{
		Value = new InlineArrayBuilder<InlineArray4_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>
		{
			new Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4
			{
				Sign = new Anon_izyfb7
				{
					Val = 1
				},
				Exponent = -129,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 4525262841340935116L, -5140230975863971357L })
					}
				}
			},
			new Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -129,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1280809179728491599L, -704726609917121591L })
					}
				}
			},
			new Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4
			{
				Sign = new Anon_izyfb7
				{
					Val = 1
				},
				Exponent = -128,
				Mantissa = new Llvm_libc_20_1_2_BigInt_qdkjbh
				{
					Val = new Llvm_libc_20_1_2_cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4717521913597252907L, -5140230975865229125L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -4717521913577128385L, -5140230975865229125L })
					}
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
