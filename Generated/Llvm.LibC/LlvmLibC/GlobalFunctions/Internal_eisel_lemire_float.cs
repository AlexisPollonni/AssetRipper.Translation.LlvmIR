using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_eisel_lemire_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal12eisel_lemireIfEENS_3cpp8optionalINS0_13ExpandedFloatIT_EEEES6_NS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>> __llvm_libc_20_1_2_::internal::eisel_lemire<float>(__llvm_libc_20_1_2_::internal::ExpandedFloat<float>, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>")]
	public unsafe static Struct_8myw6y Invoke([MangledName("init_num.coerce")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<float>")] long Init_num, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
	{
		Llvm_libc_20_1_2_cpp_optional_6hseum llvm_libc_20_1_2_cpp_optional_6hseum = default(Llvm_libc_20_1_2_cpp_optional_6hseum);
		Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up = default(Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		void* ptr = null;
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		long num5 = 0L;
		Int128 int3 = default(Int128);
		Int128 int4 = default(Int128);
		int num6 = 0;
		int num7 = 0;
		Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up);
		Struct_8myw6y result = default(Struct_8myw6y);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up) = Init_num;
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up.Mantissa;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up.Exponent;
			if (num2 < -348 || num2 > 347)
			{
				Optional_internal_ExpandedFloat_float_Constructor_h2idu8.Invoke(&llvm_libc_20_1_2_cpp_optional_6hseum);
				goto IL_04f9;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = Cpp_countl_zero_unsigned_int.Invoke(num);
			num <<= num3;
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = checked(Internal_exp10_to_exp2.Invoke(num2) + 32 + 127) - num3;
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			long num8 = checked(num2 - -348);
			ptr = (byte*)Llvm_libc_20_1_2_internal_DETAILED_POWERS_OF_TEN.Pointer + (nint)num8 * sizeof(InlineArray2_Int64);
			Llvm_lifetime_start_p0.Invoke(16L, &@int);
			@int = NumericHelper.Multiply((Int128)(UInt128)(uint)num, (Int128)(UInt128)((ulong*)ptr)[1]);
			Llvm_lifetime_start_p0.Invoke(16L, &int2);
			int2 = -6148914691236517206L;
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = 63L;
			if ((Internal_high64.Invoke(&@int) & 0x3FL) == 63L && (ulong)(Internal_low64.Invoke(&@int) + (uint)num) < (ulong)(uint)num)
			{
				Llvm_lifetime_start_p0.Invoke(16L, &int3);
				int3 = NumericHelper.Multiply((Int128)(UInt128)(uint)num, (Int128)(UInt128)(*(ulong*)ptr));
				Llvm_lifetime_start_p0.Invoke(16L, &int4);
				int4 = NumericHelper.Add(@int, (Int128)(UInt128)(ulong)Internal_high64.Invoke(&int3));
				int num9;
				if ((Internal_high64.Invoke(&int4) & 0x3FL) == 63L && Internal_low64.Invoke(&int4) + 1L == 0L && (ulong)(Internal_low64.Invoke(&int3) + (uint)num) < (ulong)(uint)num)
				{
					Optional_internal_ExpandedFloat_float_Constructor_h2idu8.Invoke(&llvm_libc_20_1_2_cpp_optional_6hseum);
					num9 = 1;
				}
				else
				{
					int2 = int4;
					num9 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(16L, &int4);
				Llvm_lifetime_end_p0.Invoke(16L, &int3);
				switch (num9)
				{
				case 0:
					break;
				default:
					goto IL_0497;
				}
			}
			else
			{
				int2 = @int;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = (int)(Internal_high64.Invoke(&int2) >>> 31);
			Llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = (int)(Internal_high64.Invoke(&int2) >>> (int)(uint)(num6 + 32 - 26));
			num4 -= 1 ^ num6;
			if (Round == RoundDirection_b3pcwy.Nearest)
			{
				if (Internal_low64.Invoke(&int2) == 0L && (Internal_high64.Invoke(&int2) & 0x3FL) == 0L && (num7 & 3) == 1)
				{
					Optional_internal_ExpandedFloat_float_Constructor_h2idu8.Invoke(&llvm_libc_20_1_2_cpp_optional_6hseum);
					goto IL_0475;
				}
				num7 += num7 & 1;
			}
			else if (Round == RoundDirection_b3pcwy.Up && ((ulong)Internal_low64.Invoke(&int2) > 0uL || (ulong)(Internal_high64.Invoke(&int2) & 0x3FL) > 0uL))
			{
				num7 += 2;
			}
			num7 >>>= 1;
			if ((uint)num7 >> 24 != 0)
			{
				num7 >>>= 1;
				num4 = checked(num4 + 1);
			}
			if ((uint)(num4 - 1) >= 254u)
			{
				Optional_internal_ExpandedFloat_float_Constructor_h2idu8.Invoke(&llvm_libc_20_1_2_cpp_optional_6hseum);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2);
				*(int*)(&llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2) = -1431655766;
				((int*)(&llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2))[1] = -1431655766;
				llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2.Mantissa = num7;
				llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2.Exponent = num4;
				Optional_internal_ExpandedFloat_float_Constructor_cm37bp.Invoke(&llvm_libc_20_1_2_cpp_optional_6hseum, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2);
			}
			goto IL_0475;
		}
		IL_0497:
		Llvm_lifetime_end_p0.Invoke(8L, &num5);
		Llvm_lifetime_end_p0.Invoke(16L, &int2);
		Llvm_lifetime_end_p0.Invoke(16L, &@int);
		Llvm_lifetime_end_p0.Invoke(8L, &ptr);
		Llvm_lifetime_end_p0.Invoke(4L, &num4);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_04f9;
		IL_0475:
		Llvm_lifetime_end_p0.Invoke(4L, &num7);
		Llvm_lifetime_end_p0.Invoke(4L, &num6);
		goto IL_0497;
		IL_04f9:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_memcpy_p0_p0_i64.Invoke(&result, &llvm_libc_20_1_2_cpp_optional_6hseum.Storage, 12L, isVolatile: false);
		return result;
	}
}
