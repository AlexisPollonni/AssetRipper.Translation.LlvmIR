using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicIjE8exchangeEjNS0_11MemoryOrderENS0_11MemoryScopeE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned int>::exchange(unsigned int, __llvm_libc_20_1_2_::cpp::MemoryOrder, __llvm_libc_20_1_2_::cpp::MemoryScope)")]
internal static partial class cpp_Atomic_unsigned_int_exchange_unsigned_int_cpp_MemoryOrder_cpp_MemoryScope
{
	public unsafe static int Invoke(void* @this, int desired, int mem_ord, int mem_scope)
	{
		int num = 0;
		int num2 = desired;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		unchecked
		{
			cpp_Atomic_unsigned_int_addressof_unsigned_int.Invoke(&((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0);
			int num3 = cpp_Atomic_unsigned_int_order_cpp_MemoryOrder.Invoke(mem_ord);
			int num4 = cpp_Atomic_unsigned_int_scope_cpp_MemoryScope.Invoke(mem_scope);
			void* ptr = cpp_Atomic_unsigned_int_addressof_unsigned_int.Invoke(&num2);
			void* ptr2 = cpp_Atomic_unsigned_int_addressof_unsigned_int.Invoke(&num);
			switch (num3)
			{
			default:
			{
				int num6 = num4;
				if (num6 != 1)
				{
					if (num6 != 2)
					{
						if (num6 != 3)
						{
							if (num6 != 4)
							{
								_ = *(int*)ptr;
								*(int*)ptr2 = 0;
							}
							else
							{
								_ = *(int*)ptr;
								*(int*)ptr2 = 0;
							}
						}
						else
						{
							_ = *(int*)ptr;
							*(int*)ptr2 = 0;
						}
					}
					else
					{
						_ = *(int*)ptr;
						*(int*)ptr2 = 0;
					}
				}
				else
				{
					_ = *(int*)ptr;
					*(int*)ptr2 = 0;
				}
				break;
			}
			case 1:
			case 2:
			{
				int num7 = num4;
				if (num7 != 1)
				{
					if (num7 != 2)
					{
						if (num7 != 3)
						{
							if (num7 != 4)
							{
								_ = *(int*)ptr;
								*(int*)ptr2 = 0;
							}
							else
							{
								_ = *(int*)ptr;
								*(int*)ptr2 = 0;
							}
						}
						else
						{
							_ = *(int*)ptr;
							*(int*)ptr2 = 0;
						}
					}
					else
					{
						_ = *(int*)ptr;
						*(int*)ptr2 = 0;
					}
				}
				else
				{
					_ = *(int*)ptr;
					*(int*)ptr2 = 0;
				}
				break;
			}
			case 3:
			{
				int num9 = num4;
				if (num9 != 1)
				{
					if (num9 != 2)
					{
						if (num9 != 3)
						{
							if (num9 != 4)
							{
								_ = *(int*)ptr;
								*(int*)ptr2 = 0;
							}
							else
							{
								_ = *(int*)ptr;
								*(int*)ptr2 = 0;
							}
						}
						else
						{
							_ = *(int*)ptr;
							*(int*)ptr2 = 0;
						}
					}
					else
					{
						_ = *(int*)ptr;
						*(int*)ptr2 = 0;
					}
				}
				else
				{
					_ = *(int*)ptr;
					*(int*)ptr2 = 0;
				}
				break;
			}
			case 4:
			{
				int num8 = num4;
				if (num8 != 1)
				{
					if (num8 != 2)
					{
						if (num8 != 3)
						{
							if (num8 != 4)
							{
								_ = *(int*)ptr;
								*(int*)ptr2 = 0;
							}
							else
							{
								_ = *(int*)ptr;
								*(int*)ptr2 = 0;
							}
						}
						else
						{
							_ = *(int*)ptr;
							*(int*)ptr2 = 0;
						}
					}
					else
					{
						_ = *(int*)ptr;
						*(int*)ptr2 = 0;
					}
				}
				else
				{
					_ = *(int*)ptr;
					*(int*)ptr2 = 0;
				}
				break;
			}
			case 5:
			{
				int num5 = num4;
				if (num5 != 1)
				{
					if (num5 != 2)
					{
						if (num5 != 3)
						{
							if (num5 != 4)
							{
								_ = *(int*)ptr;
								*(int*)ptr2 = 0;
							}
							else
							{
								_ = *(int*)ptr;
								*(int*)ptr2 = 0;
							}
						}
						else
						{
							_ = *(int*)ptr;
							*(int*)ptr2 = 0;
						}
					}
					else
					{
						_ = *(int*)ptr;
						*(int*)ptr2 = 0;
					}
				}
				else
				{
					_ = *(int*)ptr;
					*(int*)ptr2 = 0;
				}
				break;
			}
			}
			int result = num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
