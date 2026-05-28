using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_18tan_evalERKNS_6fputil11DyadicFloatILm128EEE.TAN_COEFFS")]
[DemangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_18tan_evalERKNS_6fputil11DyadicFloatILm128EEE.TAN_COEFFS")]
internal static partial class TAN_COEFFS
{
	[FixedAddressValueType]
	private static InlineArray9_Fputil_DyadicFloat_kt2kd4 __value;

	public unsafe static InlineArray9_Fputil_DyadicFloat_kt2kd4* Pointer => unchecked((InlineArray9_Fputil_DyadicFloat_kt2kd4*)Unsafe.AsPointer(ref __value));

	public static InlineArray9_Fputil_DyadicFloat_kt2kd4 Value
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

	unsafe static TAN_COEFFS()
	{
		Value = new InlineArrayBuilder<InlineArray9_Fputil_DyadicFloat_kt2kd4, Fputil_DyadicFloat_kt2kd4>
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
				Sign = default(Anon_izyfb7),
				Exponent = -129,
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
				Sign = default(Anon_izyfb7),
				Exponent = -130,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -8608480567731124087L, -8608480567731124088L })
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
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -3396543353254457123L, -2518126968792097523L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -133,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 7736570971301819002L, -5537276616129392743L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -134,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -2698187539452260662L, -7982882474662173574L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -136,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { -1871576714909950020L, -1483399031623320145L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -137,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1065575500461742449L, -4696777045669112395L })
					}
				}
			},
			new Fputil_DyadicFloat_kt2kd4
			{
				Sign = default(Anon_izyfb7),
				Exponent = -138,
				Mantissa = new BigInt_qdkjbh
				{
					Val = new Cpp_array_i3937k
					{
						Data = InlineArrayHelper.Create<InlineArray2_Int64, long>(new long[2] { 1957596769649065226L, -7301440829330414959L })
					}
				}
			}
		};
		_ = Pointer;
	}
}
