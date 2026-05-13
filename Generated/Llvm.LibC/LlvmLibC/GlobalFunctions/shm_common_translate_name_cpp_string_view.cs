using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10shm_common14translate_nameENS_3cpp11string_viewE")]
[DemangledName("__llvm_libc_20_1_2_::shm_common::translate_name(__llvm_libc_20_1_2_::cpp::string_view)")]
internal static partial class shm_common_translate_name_cpp_string_view
{
	public unsafe static void Invoke([MangledName("agg.result")] cpp_optional_pjf72b* agg_result, [MangledName("name.coerce0")] void* name, [MangledName("name.coerce1")] long offset)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		long num = 0L;
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		cpp_string_view cpp_string_view4 = default(cpp_string_view);
		cpp_string_view cpp_string_view5 = default(cpp_string_view);
		cpp_array_55kc72 cpp_array_55kc73 = default(cpp_array_55kc72);
		unchecked
		{
			*(void**)(&cpp_string_view2) = name;
			((long*)(&cpp_string_view2))[1] = offset;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = cpp_string_view_find_first_not_of_char_unsigned_long_const.Invoke(&cpp_string_view2, 47, 0L);
			if (num == -1L)
			{
				Errno_operator_int_dntwiy.Invoke(libc_errno.Pointer, 22);
				cpp_optional_cpp_array_char_265ul_optional_cpp_nullopt_t.Invoke(agg_result);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view3);
				Struct_kqhe8i struct_kqhe8i = cpp_string_view_substr_unsigned_long_unsigned_long_const.Invoke(&cpp_string_view2, num, -1L);
				cpp_string_view* num2 = &cpp_string_view3;
				Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
				*(void**)num2 = struct_kqhe8i2.field_0;
				byte* num3 = (byte*)(&cpp_string_view3) + 8u;
				Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
				*(long*)num3 = struct_kqhe8i3.field_1;
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &cpp_string_view3, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view3);
				if ((ulong)cpp_string_view_size_const.Invoke(&cpp_string_view2) > 255uL)
				{
					Errno_operator_int_dntwiy.Invoke(libc_errno.Pointer, 36);
					cpp_optional_cpp_array_char_265ul_optional_cpp_nullopt_t.Invoke(agg_result);
				}
				else
				{
					cpp_string_view_string_view_char_const.Invoke(&cpp_string_view4, str_109.Pointer);
					if (!cpp_string_view_operator_cpp_string_view_const.Invoke(&cpp_string_view2, *(void**)(&cpp_string_view4), ((long*)(&cpp_string_view4))[1]))
					{
						cpp_string_view_string_view_char_const.Invoke(&cpp_string_view5, str_1_110.Pointer);
						if (!cpp_string_view_operator_cpp_string_view_const.Invoke(&cpp_string_view2, *(void**)(&cpp_string_view5), ((long*)(&cpp_string_view5))[1]) && !cpp_string_view_contains_char_const.Invoke(&cpp_string_view2, 47))
						{
							llvm_lifetime_start_p0.Invoke(265L, &cpp_array_55kc73);
							llvm_memset_p0_i64.Invoke(&cpp_array_55kc73, -86, 265L, isVolatile: false);
							inline_memcpy_void_void_const_unsigned_long.Invoke(cpp_array_char_265ul_data.Invoke(&cpp_array_55kc73), cpp_string_view_data_const.Invoke(shm_common_SHM_PREFIX.Pointer), cpp_string_view_size_const.Invoke(shm_common_SHM_PREFIX.Pointer));
							inline_memcpy_void_void_const_unsigned_long.Invoke((byte*)cpp_array_char_265ul_data.Invoke(&cpp_array_55kc73) + cpp_string_view_size_const.Invoke(shm_common_SHM_PREFIX.Pointer), cpp_string_view_data_const.Invoke(&cpp_string_view2), cpp_string_view_size_const.Invoke(&cpp_string_view2));
							*(sbyte*)cpp_array_char_265ul_operator_unsigned_long.Invoke(&cpp_array_55kc73, cpp_string_view_size_const.Invoke(shm_common_SHM_PREFIX.Pointer) + cpp_string_view_size_const.Invoke(&cpp_string_view2)) = 0;
							cpp_optional_cpp_array_char_265ul_optional_cpp_array_char_265ul.Invoke(agg_result, &cpp_array_55kc73);
							llvm_lifetime_end_p0.Invoke(265L, &cpp_array_55kc73);
							goto IL_0234;
						}
					}
					Errno_operator_int_dntwiy.Invoke(libc_errno.Pointer, 22);
					cpp_optional_cpp_array_char_265ul_optional_cpp_nullopt_t.Invoke(agg_result);
				}
			}
			goto IL_0234;
		}
		IL_0234:
		llvm_lifetime_end_p0.Invoke(8L, &num);
	}
}
